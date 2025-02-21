using System;
using System.Security.Cryptography;
using System.Text;

public static class EncryptionHelper
{
    private static readonly string key = "your_secret_key"; // Установите ваш секретный ключ

    public static string Encrypt(string plainText)
    {
        if (string.IsNullOrEmpty(plainText))
            throw new ArgumentException("Plain text cannot be null or empty.");

        byte[] plainBytes = Encoding.UTF8.GetBytes(plainText);
        byte[] keyBytes = Encoding.UTF8.GetBytes(key);

        using (var aes = Aes.Create())
        {
            aes.Key = keyBytes;
            aes.GenerateIV();
            byte[] iv = aes.IV;

            using (var encryptor = aes.CreateEncryptor())
            {
                byte[] cipherBytes = encryptor.TransformFinalBlock(plainBytes, 0, plainBytes.Length);
                byte[] result = new byte[iv.Length + cipherBytes.Length];
                Buffer.BlockCopy(iv, 0, result, 0, iv.Length);
                Buffer.BlockCopy(cipherBytes, 0, result, iv.Length, cipherBytes.Length);
                return Convert.ToBase64String(result);
            }
        }
    }

    public static string Decrypt(string cipherText)
    {
        if (string.IsNullOrEmpty(cipherText))
            throw new ArgumentException("Cipher text cannot be null or empty.");

        byte[] cipherBytes = Convert.FromBase64String(cipherText);
        byte[] keyBytes = Encoding.UTF8.GetBytes(key);

        using (var aes = Aes.Create())
        {
            aes.Key = keyBytes;
            byte[] iv = new byte[16];
            byte[] cipher = new byte[cipherBytes.Length - iv.Length];
            Buffer.BlockCopy(cipherBytes, 0, iv, 0, iv.Length);
            Buffer.BlockCopy(cipherBytes, iv.Length, cipher, 0, cipher.Length);
            aes.IV = iv;

            using (var decryptor = aes.CreateDecryptor())
            {
                byte[] plainBytes = decryptor.TransformFinalBlock(cipher, 0, cipher.Length);
                return Encoding.UTF8.GetString(plainBytes);
            }
        }
    }
}

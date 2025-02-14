using UnityEngine;

public class SecurityManager : MonoBehaviour
{
    private void Start()
    {
        string originalText = "This is a secret message!";
        Debug.Log($"Original: {originalText}");

        string encryptedText = EncryptionHelper.Encrypt(originalText);
        Debug.Log($"Encrypted: {encryptedText}");

        string decryptedText = EncryptionHelper.Decrypt(encryptedText);
        Debug.Log($"Decrypted: {decryptedText}");
    }
}

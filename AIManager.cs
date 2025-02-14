private void LoadAPIKey()
{
    if (aiConfig != null && !string.IsNullOrEmpty(aiConfig.apiKey))
    {
        // Дешифруем API-ключ перед использованием
        apiKey = EncryptionHelper.Decrypt(aiConfig.apiKey);
    }
    else
    {
        Debug.LogError("AIConfig не назначен или API-ключ отсутствует!");
    }
}

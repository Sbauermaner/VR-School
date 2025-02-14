[SerializeField] private AIConfig aiConfig;

private void LoadAPIKey()
{
    if (aiConfig != null && !string.IsNullOrEmpty(aiConfig.apiKey))
    {
        apiKey = aiConfig.apiKey;
    }
    else
    {
        Debug.LogError("AIConfig не назначен или API-ключ отсутствует!");
    }
}

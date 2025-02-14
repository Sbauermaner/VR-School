using UnityEngine;

public class AIManager : MonoBehaviour
{
    [SerializeField] private AIConfig aiConfig;

    void Start()
    {
        if (aiConfig == null)
        {
            Debug.LogError("AIConfig не назначен!");
            return;
        }

        InitializeAI(aiConfig.apiKey);
    }

    private void InitializeAI(string apiKey)
    {
        Debug.Log($"Инициализация ИИ с ключом: {apiKey}");
        // Здесь можно добавить логику для работы с API
    }
}

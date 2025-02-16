using UnityEngine;

public class GameManager : MonoBehaviour
{
    [SerializeField] private AIManager aiManager;

    void Start()
    {
        if (aiManager == null)
        {
            Debug.LogError("AIManager не назначен!");
            return;
        }

        aiManager.SendMessageToAI("Привет, как дела?", response =>
        {
            Debug.Log($"Ответ ИИ: {response}");
        });
    }
}

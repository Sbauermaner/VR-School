using UnityEngine;

public class VoiceChat : MonoBehaviour
{
    public void Initialize()
    {
        Debug.Log("Голосовой чат инициализирован.");
        // Интеграция с библиотекой для голосового чата (например, Photon Voice)
    }

    public void StartVoiceChat()
    {
        Debug.Log("Голосовой чат запущен.");
    }

    public void StopVoiceChat()
    {
        Debug.Log("Голосовой чат остановлен.");
    }
}

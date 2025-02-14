using UnityEngine;

public class PushService : MonoBehaviour
{
    public void SendPush(string userId, string message)
    {
        // Интеграция с Firebase Cloud Messaging (FCM) или OneSignal
        Debug.Log($"Push-уведомление отправлено: {userId}\n{message}");
    }
}

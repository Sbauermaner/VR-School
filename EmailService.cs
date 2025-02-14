using UnityEngine;

public class EmailService : MonoBehaviour
{
    public void SendEmail(string recipient, string subject, string body)
    {
        // Интеграция с SMTP-сервером или API (например, SendGrid)
        Debug.Log($"Email отправлен: {recipient}\nТема: {subject}\n{body}");
    }
}

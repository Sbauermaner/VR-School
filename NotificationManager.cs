using System.Collections.Generic;
using UnityEngine;

public class NotificationManager : MonoBehaviour
{
    public List<Notification> notifications = new List<Notification>();

    public void AddNotification(string title, string message)
    {
        Notification notification = new Notification(title, message);
        notifications.Add(notification);
        Debug.Log($"Уведомление добавлено: {title}");
    }

    public void MarkAsRead(string notificationId)
    {
        Notification notification = notifications.Find(n => n.id == notificationId);
        if (notification != null)
        {
            notification.isRead = true;
            Debug.Log($"Уведомление {notificationId} помечено как прочитанное.");
        }
    }

    public List<Notification> GetUnreadNotifications()
    {
        return notifications.FindAll(n => !n.isRead);
    }
}

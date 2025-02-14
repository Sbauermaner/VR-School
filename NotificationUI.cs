using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class NotificationUI : MonoBehaviour
{
    public GameObject notificationPanel;
    public Text notificationTitle;
    public Text notificationMessage;
    public Transform notificationList;
    public GameObject notificationPrefab;

    private NotificationManager notificationManager;

    void Start()
    {
        notificationManager = FindObjectOfType<NotificationManager>();
        UpdateNotificationList();
    }

    public void ShowNotification(Notification notification)
    {
        notificationPanel.SetActive(true);
        notificationTitle.text = notification.title;
        notificationMessage.text = notification.message;
    }

    public void UpdateNotificationList()
    {
        foreach (Transform child in notificationList)
        {
            Destroy(child.gameObject);
        }

        foreach (Notification notification in notificationManager.GetUnreadNotifications())
        {
            GameObject notificationItem = Instantiate(notificationPrefab, notificationList);
            notificationItem.GetComponentInChildren<Text>().text = notification.title;
            notificationItem.GetComponent<Button>().onClick.AddListener(() => ShowNotification(notification));
        }
    }
}

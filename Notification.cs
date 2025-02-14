using System;

[System.Serializable]
public class Notification
{
    public string id;
    public string title;
    public string message;
    public DateTime timestamp;
    public bool isRead;

    public Notification(string title, string message)
    {
        this.id = Guid.NewGuid().ToString();
        this.title = title;
        this.message = message;
        this.timestamp = DateTime.Now;
        this.isRead = false;
    }
}

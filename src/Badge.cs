using UnityEngine;

[System.Serializable]
public class Badge
{
    public string id;
    public string title;
    public string description;
    public Sprite icon;

    public Badge(string id, string title, string description, Sprite icon)
    {
        this.id = id;
        this.title = title;
        this.description = description;
        this.icon = icon;
    }
}

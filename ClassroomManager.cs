using System.Collections.Generic;
using UnityEngine;

public class ClassroomManager : MonoBehaviour
{
    public List<UserAvatar> users = new List<UserAvatar>();
    public Whiteboard whiteboard;
    public VoiceChat voiceChat;

    void Start()
    {
        InitializeClassroom();
    }

    private void InitializeClassroom()
    {
        Debug.Log("Виртуальный класс инициализирован.");
        whiteboard.Initialize();
        voiceChat.Initialize();
    }

    public void AddUser(UserAvatar user)
    {
        users.Add(user);
        Debug.Log($"Пользователь {user.username} присоединился к классу.");
    }

    public void RemoveUser(UserAvatar user)
    {
        users.Remove(user);
        Debug.Log($"Пользователь {user.username} покинул класс.");
    }
}

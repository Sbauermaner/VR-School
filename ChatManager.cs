using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ChatManager : MonoBehaviour
{
    [SerializeField] private AIManager aiManager;
    [SerializeField] private InputField userInputField;
    [SerializeField] private Text chatHistory;

    private Queue<string> chatQueue = new Queue<string>();
    private const int MaxChatHistory = 10;

    public void SendMessageToAI()
    {
        string userInput = userInputField.text;
        if (!string.IsNullOrEmpty(userInput))
        {
            AddToChatHistory($"You: {userInput}");
            aiManager.SendMessageToAI(userInput, OnAIResponse);
            userInputField.text = "";
        }
    }

    private void OnAIResponse(string response)
    {
        AddToChatHistory($"AI: {response}");
    }

    private void AddToChatHistory(string message)
    {
        if (chatQueue.Count >= MaxChatHistory)
        {
            chatQueue.Dequeue();
        }
        chatQueue.Enqueue(message);
        chatHistory.text = string.Join("\n", chatQueue.ToArray());
    }
}

using System;
using System.Collections;
using UnityEngine;
using UnityEngine.Networking;

public class AIManager : MonoBehaviour
{
    private string apiUrl = "https://api.openai.com/v1/chat/completions";
    private string apiKey;

    private void Awake()
    {
        LoadAPIKey();
    }

    private void LoadAPIKey()
    {
        apiKey = Environment.GetEnvironmentVariable("OPENAI_API_KEY");

        if (string.IsNullOrEmpty(apiKey))
        {
            Debug.LogError("API Key not found in environment variables! Please set it locally.");
        }
    }

    public void SendMessageToAI(string userInput, Action<string> callback)
    {
        if (string.IsNullOrWhiteSpace(apiKey))
        {
            callback("Error: API Key is missing!");
            return;
        }

        StartCoroutine(SendRequest(userInput, callback));
    }

    private IEnumerator SendRequest(string prompt, Action<string> callback)
    {
        OpenAIRequest requestBody = new OpenAIRequest
        {
            model = "gpt-3.5-turbo",
            messages = new OpenAIRequest.Message[]
            {
                new OpenAIRequest.Message { role = "user", content = prompt }
            }
        };

        string jsonBody = JsonUtility.ToJson(requestBody);

        using (UnityWebRequest request = UnityWebRequest.Post(apiUrl, ""))
        {
            request.uploadHandler = new UploadHandlerRaw(System.Text.Encoding.UTF8.GetBytes(jsonBody));
            request.downloadHandler = new DownloadHandlerBuffer();
            request.SetRequestHeader("Authorization", $"Bearer {apiKey}");
            request.SetRequestHeader("Content-Type", "application/json");

            yield return request.SendWebRequest();

            if (request.result == UnityWebRequest.Result.Success)
            {
                OpenAIResponse response = JsonUtility.FromJson<OpenAIResponse>(request.downloadHandler.text);
                callback(response.choices[0].message.content.Trim());
            }
            else
            {
                callback($"Error: {request.error}");
            }
        }
    }
}

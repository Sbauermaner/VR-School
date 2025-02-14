using System.Collections;
using UnityEngine;
using UnityEngine.Networking;

public class MicrosoftTeamsIntegration : MonoBehaviour
{
    private string clientId;
    private string tenantId;

    void Start()
    {
        LoadConfig();
    }

    private void LoadConfig()
    {
        // Загрузка конфигурации из файла
        TextAsset configFile = Resources.Load<TextAsset>("Configs/MicrosoftConfig");
        var config = JsonUtility.FromJson<MicrosoftConfig>(configFile.text);
        clientId = config.clientId;
        tenantId = config.tenantId;
    }

    public IEnumerator CreateMeeting(string meetingTitle)
    {
        string url = $"https://graph.microsoft.com/v1.0/me/onlineMeetings";
        string jsonBody = $"{{\"subject\":\"{meetingTitle}\"}}";

        using (UnityWebRequest request = UnityWebRequest.Post(url, jsonBody))
        {
            request.SetRequestHeader("Authorization", "Bearer YOUR_ACCESS_TOKEN");
            request.SetRequestHeader("Content-Type", "application/json");

            yield return request.SendWebRequest();

            if (request.result == UnityWebRequest.Result.Success)
            {
                Debug.Log("Встреча создана: " + request.downloadHandler.text);
            }
            else
            {
                Debug.LogError("Ошибка при создании встречи: " + request.error);
            }
        }
    }

    [System.Serializable]
    private class MicrosoftConfig
    {
        public string clientId;
        public string tenantId;
    }
}

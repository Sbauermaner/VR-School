using System.Collections;
using UnityEngine;
using UnityEngine.Networking;

public class GoogleClassroomIntegration : MonoBehaviour
{
    private string apiKey;
    private string clientId;
    private string clientSecret;

    void Start()
    {
        LoadConfig();
    }

    private void LoadConfig()
    {
        // Загрузка конфигурации из файла
        TextAsset configFile = Resources.Load<TextAsset>("Configs/GoogleConfig");
        var config = JsonUtility.FromJson<GoogleConfig>(configFile.text);
        apiKey = config.apiKey;
        clientId = config.clientId;
        clientSecret = config.clientSecret;
    }

    public IEnumerator GetCourses()
    {
        string url = $"https://classroom.googleapis.com/v1/courses?key={apiKey}";
        using (UnityWebRequest request = UnityWebRequest.Get(url))
        {
            yield return request.SendWebRequest();

            if (request.result == UnityWebRequest.Result.Success)
            {
                Debug.Log("Курсы получены: " + request.downloadHandler.text);
            }
            else
            {
                Debug.LogError("Ошибка при получении курсов: " + request.error);
            }
        }
    }

    [System.Serializable]
    private class GoogleConfig
    {
        public string apiKey;
        public string clientId;
        public string clientSecret;
    }
}

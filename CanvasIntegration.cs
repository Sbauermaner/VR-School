using System.Collections;
using UnityEngine;
using UnityEngine.Networking;

public class CanvasIntegration : MonoBehaviour
{
    private string apiKey;
    private string canvasUrl;

    void Start()
    {
        LoadConfig();
    }

    private void LoadConfig()
    {
        // Загрузка конфигурации из файла
        TextAsset configFile = Resources.Load<TextAsset>("LMSConfig/CanvasConfig");
        var config = JsonUtility.FromJson<CanvasConfig>(configFile.text);
        apiKey = config.apiKey;
        canvasUrl = config.canvasUrl;
    }

    public IEnumerator GetCourses()
    {
        string url = $"{canvasUrl}/api/v1/courses?access_token={apiKey}";
        using (UnityWebRequest request = UnityWebRequest.Get(url))
        {
            yield return request.SendWebRequest();

            if (request.result == UnityWebRequest.Result.Success)
            {
                Debug.Log("Курсы Canvas получены: " + request.downloadHandler.text);
            }
            else
            {
                Debug.LogError("Ошибка при получении курсов Canvas: " + request.error);
            }
        }
    }

    [System.Serializable]
    private class CanvasConfig
    {
        public string apiKey;
        public string canvasUrl;
    }
}

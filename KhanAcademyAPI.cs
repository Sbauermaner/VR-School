using System.Collections;
using UnityEngine;
using UnityEngine.Networking;

public class KhanAcademyAPI : MonoBehaviour
{
    private string apiKey;

    void Start()
    {
        LoadConfig();
    }

    private void LoadConfig()
    {
        // Загрузка конфигурации из файла
        TextAsset configFile = Resources.Load<TextAsset>("Configs/KhanAcademyConfig");
        var config = JsonUtility.FromJson<KhanAcademyConfig>(configFile.text);
        apiKey = config.apiKey;
    }

    public IEnumerator GetTopicVideos(string topic)
    {
        string url = $"https://www.khanacademy.org/api/v1/topic/{topic}/videos";
        using (UnityWebRequest request = UnityWebRequest.Get(url))
        {
            yield return request.SendWebRequest();

            if (request.result == UnityWebRequest.Result.Success)
            {
                Debug.Log("Видео получены: " + request.downloadHandler.text);
            }
            else
            {
                Debug.LogError("Ошибка при получении видео: " + request.error);
            }
        }
    }

    [System.Serializable]
    private class KhanAcademyConfig
    {
        public string apiKey;
    }
}

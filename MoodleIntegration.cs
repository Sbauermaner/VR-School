using System.Collections;
using UnityEngine;
using UnityEngine.Networking;

public class MoodleIntegration : MonoBehaviour
{
    private string apiKey;
    private string moodleUrl;

    void Start()
    {
        LoadConfig();
    }

    private void LoadConfig()
    {
        // Загрузка конфигурации из файла
        TextAsset configFile = Resources.Load<TextAsset>("LMSConfig/MoodleConfig");
        var config = JsonUtility.FromJson<MoodleConfig>(configFile.text);
        apiKey = config.apiKey;
        moodleUrl = config.moodleUrl;
    }

    public IEnumerator GetCourses()
    {
        string url = $"{moodleUrl}/webservice/rest/server.php?wstoken={apiKey}&wsfunction=core_course_get_courses&moodlewsrestformat=json";
        using (UnityWebRequest request = UnityWebRequest.Get(url))
        {
            yield return request.SendWebRequest();

            if (request.result == UnityWebRequest.Result.Success)
            {
                Debug.Log("Курсы Moodle получены: " + request.downloadHandler.text);
            }
            else
            {
                Debug.LogError("Ошибка при получении курсов Moodle: " + request.error);
            }
        }
    }

    [System.Serializable]
    private class MoodleConfig
    {
        public string apiKey;
        public string moodleUrl;
    }
}

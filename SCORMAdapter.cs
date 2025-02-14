using System.Collections;
using UnityEngine;

public class SCORMAdapter : MonoBehaviour
{
    private string scormVersion;

    void Start()
    {
        LoadConfig();
    }

    private void LoadConfig()
    {
        // Загрузка конфигурации из файла
        TextAsset configFile = Resources.Load<TextAsset>("LMSConfig/SCORMConfig");
        var config = JsonUtility.FromJson<SCORMConfig>(configFile.text);
        scormVersion = config.scormVersion;
    }

    public void SendCompletionStatus(string status)
    {
        Debug.Log($"SCORM {scormVersion}: Статус завершения отправлен - {status}");
    }

    public void SendScore(float score)
    {
        Debug.Log($"SCORM {scormVersion}: Оценка отправлена - {score}");
    }

    [System.Serializable]
    private class SCORMConfig
    {
        public string scormVersion;
    }
}

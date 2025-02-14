using System.IO;
using UnityEngine;

public class LessonRecorder : MonoBehaviour
{
    private string recordingPath;
    private bool isRecording = false;

    void Start()
    {
        recordingPath = Path.Combine(Application.persistentDataPath, "Recordings");
        if (!Directory.Exists(recordingPath))
        {
            Directory.CreateDirectory(recordingPath);
        }
    }

    public void StartRecording()
    {
        isRecording = true;
        Debug.Log("Запись урока начата.");
    }

    public void StopRecording()
    {
        isRecording = false;
        Debug.Log("Запись урока остановлена.");
    }

    public void SaveRecording(string lessonId)
    {
        if (isRecording)
        {
            string filePath = Path.Combine(recordingPath, $"{lessonId}.mp4");
            // Сохранение записи (заглушка, требуется интеграция с API записи)
            Debug.Log($"Запись сохранена: {filePath}");
        }
        else
        {
            Debug.LogError("Запись не активна.");
        }
    }
}

using System.Collections.Generic;
using UnityEngine;

public class AnalyticsManager : MonoBehaviour
{
    public Dictionary<string, ProgressData> studentProgress = new Dictionary<string, ProgressData>();

    void Start()
    {
        LoadProgressData();
    }

    private void LoadProgressData()
    {
        // Загрузка данных из файла или базы данных
        studentProgress = new Dictionary<string, ProgressData>
        {
            { "student1", new ProgressData("student1") },
            { "student2", new ProgressData("student2") }
        };
    }

    public void AddTestResult(string studentId, string testId, float score)
    {
        if (studentProgress.ContainsKey(studentId))
        {
            studentProgress[studentId].AddTestScore(testId, score);
        }
        else
        {
            Debug.LogError($"Student {studentId} not found!");
        }
    }

    public void CompleteLesson(string studentId, string lessonId)
    {
        if (studentProgress.ContainsKey(studentId))
        {
            studentProgress[studentId].CompleteLesson(lessonId);
        }
        else
        {
            Debug.LogError($"Student {studentId} not found!");
        }
    }
}

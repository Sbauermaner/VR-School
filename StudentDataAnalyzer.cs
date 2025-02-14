using System.Collections.Generic;
using UnityEngine;

public class StudentDataAnalyzer : MonoBehaviour
{
    public StudentReport GetStudentData(string studentId)
    {
        // Загрузка данных из аналитики (пример)
        return new StudentReport(studentId)
        {
            preferredTopics = new List<string> { "math", "physics" },
            timeSpentPerTopic = new Dictionary<string, int> { { "math", 120 }, { "physics", 90 } }
        };
    }

    public float[] ConvertToMLInput(StudentReport report)
    {
        // Конвертация данных в вектор для модели (пример: время на темы)
        List<float> features = new List<float>();
        foreach (var topic in report.preferredTopics)
        {
            features.Add(report.timeSpentPerTopic.ContainsKey(topic) ? report.timeSpentPerTopic[topic] : 0);
        }
        return features.ToArray();
    }
}

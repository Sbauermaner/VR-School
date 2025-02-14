using System.Collections.Generic;

[System.Serializable]
public class StudentProfile
{
    public string studentName;
    public Dictionary<string, float> topicScores; // Оценки по темам
    public List<string> completedCourses; // Завершённые курсы

    public StudentProfile(string name)
    {
        studentName = name;
        topicScores = new Dictionary<string, float>();
        completedCourses = new List<string>();
    }

    public void UpdateScore(string topic, float score)
    {
        if (topicScores.ContainsKey(topic))
        {
            topicScores[topic] = score;
        }
        else
        {
            topicScores.Add(topic, score);
        }
    }

    public void CompleteCourse(string courseId)
    {
        if (!completedCourses.Contains(courseId))
        {
            completedCourses.Add(courseId);
        }
    }
}

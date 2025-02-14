using System.Collections.Generic;

[System.Serializable]
public class ProgressData
{
    public string studentId;
    public Dictionary<string, float> testScores; // Оценки за тесты
    public Dictionary<string, int> lessonCompletion; // Завершённые уроки

    public ProgressData(string id)
    {
        studentId = id;
        testScores = new Dictionary<string, float>();
        lessonCompletion = new Dictionary<string, int>();
    }

    public void AddTestScore(string testId, float score)
    {
        if (testScores.ContainsKey(testId))
        {
            testScores[testId] = score;
        }
        else
        {
            testScores.Add(testId, score);
        }
    }

    public void CompleteLesson(string lessonId)
    {
        if (lessonCompletion.ContainsKey(lessonId))
        {
            lessonCompletion[lessonId]++;
        }
        else
        {
            lessonCompletion.Add(lessonId, 1);
        }
    }
}

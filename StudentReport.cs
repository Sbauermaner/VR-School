using System.Collections.Generic;

[System.Serializable]
public class StudentReport
{
    public string studentId;
    public Dictionary<string, float> testScores; // Оценки за тесты
    public Dictionary<string, int> lessonCompletion; // Завершённые уроки
    public Dictionary<string, int> assignmentGrades; // Оценки за задания

    public StudentReport(string id)
    {
        studentId = id;
        testScores = new Dictionary<string, float>();
        lessonCompletion = new Dictionary<string, int>();
        assignmentGrades = new Dictionary<string, int>();
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

    public void AddAssignmentGrade(string assignmentId, int grade)
    {
        if (assignmentGrades.ContainsKey(assignmentId))
        {
            assignmentGrades[assignmentId] = grade;
        }
        else
        {
            assignmentGrades.Add(assignmentId, grade);
        }
    }
}
[System.Serializable]
public class StudentReport
{
    // ... существующие поля ...
    public List<string> preferredTopics; // Любимые темы (например, "математика", "история")
    public Dictionary<string, int> timeSpentPerTopic; // Время, затраченное на каждую тему
}

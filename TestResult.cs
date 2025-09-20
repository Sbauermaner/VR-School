using System.Collections.Generic;

[System.Serializable]
public class TestResult
{
    public string testTitle;
    public int score;
    public int totalQuestions;
    public List<string> feedback;

    public float GetPercentage()
    {
        return (float)score / totalQuestions * 100;
    }
}

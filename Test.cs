using System.Collections.Generic;

[System.Serializable]
public class Test
{
    public string title;
    public List<Question> questions;

    public int CalculateScore(List<int> userAnswers)
    {
        int score = 0;
        for (int i = 0; i < questions.Count; i++)
        {
            if (questions[i].IsCorrect(userAnswers[i]))
            {
                score++;
            }
        }
        return score;
    }
}

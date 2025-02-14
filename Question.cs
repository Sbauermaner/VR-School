using System.Collections.Generic;

[System.Serializable]
public class Question
{
    public string text;
    public List<Answer> answers;
    public int correctAnswerIndex;

    public bool IsCorrect(int selectedIndex)
    {
        return selectedIndex == correctAnswerIndex;
    }
}

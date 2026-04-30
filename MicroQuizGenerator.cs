using System.Collections.Generic;
using UnityEngine;
using System.Linq;

public class MicroQuizGenerator : MonoBehaviour
{
    public QuizQuestion GenerateQuiz(List<string> topics)
    {
        // Пример: выбор случайного вопроса по теме
        return new QuizQuestion
        {
            question = "Чему равен интеграл от x²?",
            options = new List<string> { "x³/3", "x²/2", "2x" },
            correctIndex = 0
        };
    }
}

[System.Serializable]
public class QuizQuestion
{
    public string question;
    public List<string> options;
    public int correctIndex;
}

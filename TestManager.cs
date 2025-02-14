using System.Collections.Generic;
using UnityEngine;

public class TestManager : MonoBehaviour
{
    public List<Test> tests;
    private Test currentTest;
    private List<int> userAnswers = new List<int>();

    void Start()
    {
        LoadTests();
    }

    private void LoadTests()
    {
        // Загрузка тестов из Resources или внешнего API
        tests = new List<Test>
        {
            new Test
            {
                title = "Тест по математике",
                questions = new List<Question>
                {
                    new Question
                    {
                        text = "Сколько будет 2 + 2?",
                        answers = new List<Answer>
                        {
                            new Answer { text = "3" },
                            new Answer { text = "4" },
                            new Answer { text = "5" }
                        },
                        correctAnswerIndex = 1
                    }
                }
            }
        };
    }

    public void StartTest(int testIndex)
    {
        if (testIndex < 0 || testIndex >= tests.Count)
        {
            Debug.LogError("Invalid test index!");
            return;
        }

        currentTest = tests[testIndex];
        userAnswers.Clear();
        Debug.Log($"Начат тест: {currentTest.title}");
    }

    public void SubmitAnswer(int answerIndex)
    {
        userAnswers.Add(answerIndex);
        Debug.Log($"Ответ принят: {answerIndex}");
    }

    public TestResult FinishTest()
    {
        int score = currentTest.CalculateScore(userAnswers);
        var result = new TestResult
        {
            testTitle = currentTest.title,
            score = score,
            totalQuestions = currentTest.questions.Count,
            feedback = new List<string>()
        };

        Debug.Log($"Тест завершён. Оценка: {score}/{currentTest.questions.Count}");
        return result;
    }
}

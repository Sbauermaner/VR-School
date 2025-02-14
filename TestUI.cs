using UnityEngine;
using UnityEngine.UI;

public class TestUI : MonoBehaviour
{
    public Text questionText;
    public Button[] answerButtons;
    public Text resultText;

    private TestManager testManager;
    private int currentQuestionIndex = 0;

    void Start()
    {
        testManager = FindObjectOfType<TestManager>();
        testManager.StartTest(0);
        DisplayQuestion();
    }

    private void DisplayQuestion()
    {
        Question question = testManager.tests[0].questions[currentQuestionIndex];
        questionText.text = question.text;

        for (int i = 0; i < answerButtons.Length; i++)
        {
            if (i < question.answers.Count)
            {
                answerButtons[i].gameObject.SetActive(true);
                answerButtons[i].GetComponentInChildren<Text>().text = question.answers[i].text;
            }
            else
            {
                answerButtons[i].gameObject.SetActive(false);
            }
        }
    }

    public void OnAnswerSelected(int answerIndex)
    {
        testManager.SubmitAnswer(answerIndex);
        currentQuestionIndex++;

        if (currentQuestionIndex < testManager.tests[0].questions.Count)
        {
            DisplayQuestion();
        }
        else
        {
            TestResult result = testManager.FinishTest();
            resultText.text = $"Результат: {result.score}/{result.totalQuestions}";
        }
    }
}

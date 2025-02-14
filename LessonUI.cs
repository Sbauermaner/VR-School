using UnityEngine;
using UnityEngine.UI;

public class LessonUI : MonoBehaviour
{
    public Text lessonTitle;
    public Text stepContent;
    public Button nextButton;
    public Button prevButton;

    private LessonManager lessonManager;

    void Start()
    {
        lessonManager = FindObjectOfType<LessonManager>();
        nextButton.onClick.AddListener(NextStep);
        prevButton.onClick.AddListener(PreviousStep);
    }

    public void UpdateUI(string title, string content)
    {
        lessonTitle.text = title;
        stepContent.text = content;
    }

    private void NextStep()
    {
        lessonManager.DisplayStep(lessonManager.currentStepIndex + 1);
    }

    private void PreviousStep()
    {
        lessonManager.DisplayStep(lessonManager.currentStepIndex - 1);
    }
}

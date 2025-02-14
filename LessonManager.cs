using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LessonManager : MonoBehaviour
{
    public List<Lesson> lessons;
    public int currentLessonIndex = 0;
    public int currentStepIndex = 0;

    private GameObject currentModel;

    void Start()
    {
        LoadLesson(currentLessonIndex);
    }

    public void LoadLesson(int index)
    {
        if (index < 0 || index >= lessons.Count)
        {
            Debug.LogError("Invalid lesson index!");
            return;
        }

        currentLessonIndex = index;
        currentStepIndex = 0;
        DisplayStep(currentStepIndex);
    }

    public void DisplayStep(int stepIndex)
    {
        if (stepIndex < 0 || stepIndex >= lessons[currentLessonIndex].steps.Count)
        {
            Debug.LogError("Invalid step index!");
            return;
        }

        LessonStep step = lessons[currentLessonIndex].steps[stepIndex];

        switch (step.type)
        {
            case LessonStep.StepType.Text:
                DisplayText(step.content);
                break;
            case LessonStep.StepType.Video:
                DisplayVideo(step.content);
                break;
            case LessonStep.StepType.Model:
                DisplayModel(step.content, step.modelPosition, step.modelRotation);
                break;
            case LessonStep.StepType.Quiz:
                DisplayQuiz(step.content);
                break;
        }
    }

    private void DisplayText(string text)
    {
        Debug.Log($"Displaying text: {text}");
        // Отобразить текст на UI
    }

    private void DisplayVideo(string videoPath)
    {
        Debug.Log($"Displaying video: {videoPath}");
        // Воспроизвести видео
    }

    private void DisplayModel(string modelPath, Vector3 position, Quaternion rotation)
    {
        if (currentModel != null)
        {
            Destroy(currentModel);
        }

        GameObject modelPrefab = Resources.Load<GameObject>(modelPath);
        if (modelPrefab != null)
        {
            currentModel = Instantiate(modelPrefab, position, rotation);
        }
        else
        {
            Debug.LogError($"Model not found: {modelPath}");
        }
    }

    private void DisplayQuiz(string question)
    {
        Debug.Log($"Displaying quiz: {question}");
        // Отобразить вопрос и варианты ответов
    }
}

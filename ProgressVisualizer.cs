using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ProgressVisualizer : MonoBehaviour
{
    public Image progressBar;
    public Text progressText;

    public void UpdateProgress(float progress)
    {
        progressBar.fillAmount = progress;
        progressText.text = $"{progress * 100}%";
    }

    public void ShowTestResults(Dictionary<string, float> testScores)
    {
        foreach (var test in testScores)
        {
            Debug.Log($"Тест: {test.Key}, Оценка: {test.Value}");
        }
    }
}

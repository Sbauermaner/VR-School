using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ReportVisualizer : MonoBehaviour
{
    public Text studentName;
    public Image progressBar;
    public Text progressText;
    public Transform chartContainer;
    public GameObject barPrefab;

    public void DisplayReport(StudentReport report)
    {
        studentName.text = report.studentId;

        // Отображение общего прогресса
        float totalScore = 0;
        foreach (var score in report.testScores.Values)
        {
            totalScore += score;
        }
        float averageScore = totalScore / report.testScores.Count;
        progressBar.fillAmount = averageScore / 100f;
        progressText.text = $"{averageScore}%";

        // Отображение графика
        foreach (var test in report.testScores)
        {
            var bar = Instantiate(barPrefab, chartContainer);
            bar.GetComponentInChildren<Text>().text = test.Key;
            bar.GetComponentInChildren<Image>().fillAmount = test.Value / 100f;
        }
    }
}

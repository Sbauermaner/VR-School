using UnityEngine;
using System.IO;
using System.Text;

public class ReportExporter : MonoBehaviour
{
    public void ExportToCSV(StudentReport report, string filePath)
    {
        var csv = new StringBuilder();
        csv.AppendLine("Test,Score");
        foreach (var test in report.testScores)
        {
            csv.AppendLine($"{test.Key},{test.Value}");
        }
        File.WriteAllText(filePath, csv.ToString());
        Debug.Log($"Отчёт экспортирован в {filePath}");
    }
}

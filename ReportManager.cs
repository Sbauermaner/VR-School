using System.Collections.Generic;
using UnityEngine;

public class ReportManager : MonoBehaviour
{
    public Dictionary<string, StudentReport> studentReports = new Dictionary<string, StudentReport>();

    void Start()
    {
        LoadReports();
    }

    private void LoadReports()
    {
        // Загрузка данных из файла или базы данных
        studentReports = new Dictionary<string, StudentReport>
        {
            { "student1", new StudentReport("student1") },
            { "student2", new StudentReport("student2") }
        };
    }

    public void AddTestResult(string studentId, string testId, float score)
    {
        if (studentReports.ContainsKey(studentId))
        {
            studentReports[studentId].AddTestScore(testId, score);
        }
        else
        {
            Debug.LogError($"Student {studentId} not found!");
        }
    }

    public void AddAssignmentGrade(string studentId, string assignmentId, int grade)
    {
        if (studentReports.ContainsKey(studentId))
        {
            studentReports[studentId].AddAssignmentGrade(assignmentId, grade);
        }
        else
        {
            Debug.LogError($"Student {studentId} not found!");
        }
    }
}

using System.Collections.Generic;
using UnityEngine;

public class ClassroomManager : MonoBehaviour
{
    public List<GroupAssignment> assignments = new List<GroupAssignment>();
    public List<LivePoll> polls = new List<LivePoll>();
    public LessonRecorder recorder;

    void Start()
    {
        InitializeClassroom();
    }

    private void InitializeClassroom()
    {
        Debug.Log("Виртуальный класс инициализирован.");
        recorder = new LessonRecorder();
    }

    public void CreateAssignment(string title, string description)
    {
        var assignment = new GroupAssignment
        {
            assignmentId = $"assignment{assignments.Count + 1}",
            title = title,
            description = description
        };
        assignments.Add(assignment);
        Debug.Log($"Задание создано: {title}");
    }

    public void CreatePoll(string question, List<string> options)
    {
        var poll = new LivePoll
        {
            pollId = $"poll{polls.Count + 1}",
            question = question,
            options = options
        };
        polls.Add(poll);
        Debug.Log($"Опрос создан: {question}");
    }
}

using System.Collections.Generic;
using UnityEngine;

public class MicroLessonManager : MonoBehaviour
{
    public List<MicroLesson> allLessons = new List<MicroLesson>();
    private List<MicroLesson> recommendedLessons = new List<MicroLesson>();

    void Start()
    {
        LoadLessons();
        GenerateRecommendations();
    }

    private void LoadLessons()
    {
        // Загрузка уроков из папки Resources
        allLessons.Add(new MicroLesson
        {
            lessonId = "math_quiz1",
            title = "Основы алгебры",
            topic = "Algebra",
            duration = 5,
            type = MicroLesson.LessonType.Quiz,
            contentPath = "MicroLessons/Math/Algebra_Quiz1"
        });
    }

    private void GenerateRecommendations()
    {
        // Пример: рекомендации на основе слабых тем из аналитики
        recommendedLessons = allLessons
            .FindAll(lesson => lesson.topic == "Algebra")
            .GetRange(0, 3);
    }

    public MicroLesson GetNextLesson()
    {
        return recommendedLessons.Count > 0 ? recommendedLessons[0] : null;
    }
}

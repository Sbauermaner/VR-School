using System.Collections.Generic;
using UnityEngine;

public class AdaptiveManager : MonoBehaviour
{
    public StudentProfile studentProfile;
    public ProgressTracker progressTracker;
    public CourseRecommender courseRecommender;

    void Start()
    {
        studentProfile = new StudentProfile("Иван");
        progressTracker = new ProgressTracker(studentProfile);
        courseRecommender = new CourseRecommender(studentProfile);

        // Загружаем доступные курсы
        List<Course> availableCourses = LoadCourses();

        // Рекомендуем курсы
        List<string> recommendedCourses = courseRecommender.RecommendCourses(availableCourses);
        Debug.Log("Рекомендованные курсы: " + string.Join(", ", recommendedCourses));
    }

    private List<Course> LoadCourses()
    {
        // Загрузка курсов из Resources или внешнего API
        return new List<Course>
        {
            new Course { id = "course1", title = "Основы математики" },
            new Course { id = "course2", title = "Программирование на Python" },
            new Course { id = "course3", title = "История искусств" }
        };
    }
}

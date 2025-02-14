using System.Collections.Generic;
using System.Linq;

public class CourseRecommender
{
    private StudentProfile studentProfile;

    public CourseRecommender(StudentProfile profile)
    {
        studentProfile = profile;
    }

    public List<string> RecommendCourses(List<Course> availableCourses)
    {
        var recommendedCourses = new List<string>();

        foreach (var course in availableCourses)
        {
            if (!studentProfile.completedCourses.Contains(course.id))
            {
                // Рекомендуем курс, если ученик не завершил его
                recommendedCourses.Add(course.id);
            }
        }

        // Сортируем курсы по оценкам (от низких к высоким)
        recommendedCourses = recommendedCourses
            .OrderBy(courseId => studentProfile.topicScores.ContainsKey(courseId) ? studentProfile.topicScores[courseId] : 0)
            .ToList();

        return recommendedCourses;
    }
}

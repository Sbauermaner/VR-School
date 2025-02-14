using System;

public class ProgressTracker
{
    private StudentProfile studentProfile;

    public ProgressTracker(StudentProfile profile)
    {
        studentProfile = profile;
    }

    public void TrackLessonCompletion(string lessonId, float score)
    {
        studentProfile.UpdateScore(lessonId, score);
        Debug.Log($"Урок {lessonId} завершён с оценкой {score}");
    }

    public void TrackCourseCompletion(string courseId)
    {
        studentProfile.CompleteCourse(courseId);
        Debug.Log($"Курс {courseId} завершён");
    }
}

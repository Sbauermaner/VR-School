using System.Collections.Generic;

public class AchievementTracker : MonoBehaviour
{
    public Dictionary<string, bool> completedCourses = new Dictionary<string, bool>();

    public bool IsEligibleForCertificate(string courseId)
    {
        return completedCourses.ContainsKey(courseId) && completedCourses[courseId];
    }

    public void AddCompletedCourse(string courseId)
    {
        if (!completedCourses.ContainsKey(courseId))
        {
            completedCourses.Add(courseId, true);
        }
    }
}

using UnityEngine;

public class LMSManager : MonoBehaviour
{
    public MoodleIntegration moodle;
    public CanvasIntegration canvas;
    public SCORMAdapter scorm;

    void Start()
    {
        StartCoroutine(moodle.GetCourses());
        StartCoroutine(canvas.GetCourses());
        scorm.SendCompletionStatus("completed");
        scorm.SendScore(95);
    }
}

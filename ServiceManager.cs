using UnityEngine;

public class ServiceManager : MonoBehaviour
{
    public GoogleClassroomIntegration googleClassroom;
    public MicrosoftTeamsIntegration microsoftTeams;
    public KhanAcademyAPI khanAcademy;

    void Start()
    {
        StartCoroutine(googleClassroom.GetCourses());
        StartCoroutine(microsoftTeams.CreateMeeting("Урок по математике"));
        StartCoroutine(khanAcademy.GetTopicVideos("math"));
    }
}

using System.Collections.Generic;
using UnityEngine;

public class GroupAssignment : MonoBehaviour
{
    public string assignmentId;
    public string title;
    public string description;
    public List<string> participants = new List<string>();

    public void AddParticipant(string participantId)
    {
        if (!participants.Contains(participantId))
        {
            participants.Add(participantId);
            Debug.Log($"Участник {participantId} добавлен к заданию {title}.");
        }
    }

    public void SubmitAssignment(string participantId, string answer)
    {
        if (participants.Contains(participantId))
        {
            Debug.Log($"Ответ от {participantId} для задания {title}: {answer}");
        }
        else
        {
            Debug.LogError($"Участник {participantId} не найден в задании {title}.");
        }
    }
}

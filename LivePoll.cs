using System.Collections.Generic;
using UnityEngine;

public class LivePoll : MonoBehaviour
{
    public string pollId;
    public string question;
    public List<string> options;
    public Dictionary<string, int> results = new Dictionary<string, int>();

    public void StartPoll()
    {
        Debug.Log($"Опрос начат: {question}");
        foreach (var option in options)
        {
            results[option] = 0;
        }
    }

    public void SubmitVote(string option)
    {
        if (results.ContainsKey(option))
        {
            results[option]++;
            Debug.Log($"Голос за {option} принят.");
        }
        else
        {
            Debug.LogError($"Вариант {option} не найден в опросе.");
        }
    }

    public void EndPoll()
    {
        Debug.Log($"Результаты опроса {question}:");
        foreach (var result in results)
        {
            Debug.Log($"{result.Key}: {result.Value} голосов");
        }
    }
}

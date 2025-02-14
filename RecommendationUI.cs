using UnityEngine;
using UnityEngine.UI;

public class RecommendationUI : MonoBehaviour
{
    public Transform recommendationsPanel;
    public GameObject recommendationPrefab;

    public void DisplayRecommendations(string[] recommendations)
    {
        foreach (Transform child in recommendationsPanel)
        {
            Destroy(child.gameObject);
        }

        foreach (string topic in recommendations)
        {
            GameObject recommendationItem = Instantiate(recommendationPrefab, recommendationsPanel);
            recommendationItem.GetComponentInChildren<Text>().text = GetTopicName(topic); // Например, "Продвинутая математика"
        }
    }

    private string GetTopicName(string topicId)
    {
        // Сопоставление ID тем с человекочитаемыми названиями
        switch (topicId)
        {
            case "math_advanced": return "Продвинутая математика";
            case "physics_quantum": return "Квантовая физика";
            default: return topicId;
        }
    }
}

using System.Collections.Generic;

public class RecommendationSystem
{
    private ProgressData progressData;

    public RecommendationSystem(ProgressData data)
    {
        progressData = data;
    }

    public List<string> GetRecommendations()
    {
        var recommendations = new List<string>();

        // Пример рекомендаций
        if (progressData.testScores.ContainsKey("math_test") && progressData.testScores["math_test"] < 70)
        {
            recommendations.Add("Рекомендуем повторить тему 'Алгебра'.");
        }

        if (progressData.lessonCompletion.ContainsKey("history_lesson") && progressData.lessonCompletion["history_lesson"] < 2)
        {
            recommendations.Add("Рекомендуем пройти урок 'История Древнего мира' ещё раз.");
        }

        return recommendations;
    }
}

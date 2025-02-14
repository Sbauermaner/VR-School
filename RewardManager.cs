using System.Collections.Generic;
using UnityEngine;

public class RewardManager : MonoBehaviour
{
    public BadgeSystem badgeSystem;
    public LevelSystem levelSystem;

    public void RewardForLessonCompletion(string lessonId)
    {
        levelSystem.AddXP(10); // Награда за завершение урока
        badgeSystem.EarnBadge("badge1"); // Пример бейджа за первый урок
    }

    public void RewardForTestCompletion(string testId, float score)
    {
        levelSystem.AddXP((int)(score * 10)); // Награда за тест
        if (score >= 90)
        {
            badgeSystem.EarnBadge("badge2"); // Пример бейджа за высокий балл
        }
    }
}

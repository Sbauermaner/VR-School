using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AchievementUI : MonoBehaviour
{
    public Image badgeIcon;
    public Text badgeTitle;
    public Text badgeDescription;
    public Text levelText;
    public Image xpBar;

    private BadgeSystem badgeSystem;
    private LevelSystem levelSystem;

    void Start()
    {
        badgeSystem = FindObjectOfType<BadgeSystem>();
        levelSystem = FindObjectOfType<LevelSystem>();
        UpdateUI();
    }

    public void UpdateUI()
    {
        // Отображаем последний полученный бейдж
        var earnedBadges = badgeSystem.GetEarnedBadges();
        if (earnedBadges.Count > 0)
        {
            var latestBadge = earnedBadges[earnedBadges.Count - 1];
            badgeIcon.sprite = latestBadge.icon;
            badgeTitle.text = latestBadge.title;
            badgeDescription.text = latestBadge.description;
        }

        // Отображаем уровень и прогресс
        levelText.text = $"Уровень: {levelSystem.currentLevel}";
        xpBar.fillAmount = (float)levelSystem.currentXP / levelSystem.xpToNextLevel;
    }
}

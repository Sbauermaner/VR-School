using System.Collections.Generic;
using UnityEngine;

public class BadgeSystem : MonoBehaviour
{
    public List<Badge> badges = new List<Badge>();
    private List<string> earnedBadges = new List<string>();

    void Start()
    {
        LoadBadges();
    }

    private void LoadBadges()
    {
        // Загрузка бейджей из Resources
        badges = new List<Badge>
        {
            new Badge("badge1", "Новичок", "Пройдите первый урок.", Resources.Load<Sprite>("Badges/Badge1")),
            new Badge("badge2", "Математик", "Решите 10 задач по математике.", Resources.Load<Sprite>("Badges/Badge2")),
            new Badge("badge3", "Историк", "Пройдите курс истории.", Resources.Load<Sprite>("Badges/Badge3"))
        };
    }

    public void EarnBadge(string badgeId)
    {
        if (!earnedBadges.Contains(badgeId))
        {
            earnedBadges.Add(badgeId);
            Debug.Log($"Бейдж получен: {badgeId}");
        }
    }

    public List<Badge> GetEarnedBadges()
    {
        var earned = new List<Badge>();
        foreach (var badgeId in earnedBadges)
        {
            var badge = badges.Find(b => b.id == badgeId);
            if (badge != null)
            {
                earned.Add(badge);
            }
        }
        return earned;
    }
}

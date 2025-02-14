using UnityEngine;

public class LevelSystem : MonoBehaviour
{
    public int currentLevel = 1;
    public int currentXP = 0;
    public int xpToNextLevel = 100;

    public void AddXP(int amount)
    {
        currentXP += amount;
        if (currentXP >= xpToNextLevel)
        {
            LevelUp();
        }
    }

    private void LevelUp()
    {
        currentLevel++;
        currentXP = 0;
        xpToNextLevel = (int)(xpToNextLevel * 1.5f); // Увеличиваем порог для следующего уровня
        Debug.Log($"Новый уровень: {currentLevel}");
    }
}

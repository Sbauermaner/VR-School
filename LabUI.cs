using UnityEngine;
using UnityEngine.UI;

public class LabUI : MonoBehaviour
{
    public Text currentStepText;
    public Text resultText;
    public Image dangerIndicator;

    public void UpdateStep(string step)
    {
        currentStepText.text = step;
    }

    public void ShowResult(string message, Color color)
    {
        resultText.text = message;
        resultText.color = color;
    }

    public void ToggleDangerAlert(bool isDanger)
    {
        dangerIndicator.gameObject.SetActive(isDanger);
    }
}

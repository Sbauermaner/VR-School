using System.Collections.Generic;
using UnityEngine;

public class ExperimentController : MonoBehaviour
{
    public List<string> currentSteps = new List<string>();
    public int currentStepIndex = 0;

    public void StartExperiment(string experimentId)
    {
        // Загрузка шагов эксперимента из JSON
        currentSteps = new List<string> { "Нагрей пробирку", "Добавь реактив" };
        currentStepIndex = 0;
        UpdateUI();
    }

    public void CompleteStep()
    {
        currentStepIndex++;
        UpdateUI();
    }

    private void UpdateUI()
    {
        Debug.Log($"Текущий шаг: {currentSteps[currentStepIndex]}");
    }
}

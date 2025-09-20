using System.Collections.Generic;
using UnityEngine;
using Unity.Barracuda; // Для работы с ONNX-моделями

public class RecommendationEngine : MonoBehaviour
{
    public NNModel modelAsset;
    private Model model;
    private IWorker worker;

    void Start()
    {
        model = ModelLoader.Load(modelAsset);
        worker = WorkerFactory.CreateWorker(WorkerFactory.Type.Auto, model);
    }

    public string[] GetRecommendations(float[] inputFeatures)
    {
        Tensor inputTensor = new Tensor(1, inputFeatures.Length, inputFeatures);
        worker.Execute(inputTensor);
        Tensor outputTensor = worker.PeekOutput();
        float[] scores = outputTensor.ToReadOnlyArray();

        // Пример: выбор топ-3 тем
        var recommendations = new List<string> { "math_advanced", "physics_quantum", "programming_basics" };
        return recommendations.GetRange(0, 3).ToArray();
    }

    void OnDestroy()
    {
        worker.Dispose();
    }
}

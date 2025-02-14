using UnityEngine;

public class PhysicsSimulator : MonoBehaviour
{
    public void MixLiquids(GameObject liquid1, GameObject liquid2, out GameObject result)
    {
        // Пример: смешивание воды и кислоты
        if (liquid1.CompareTag("Water") && liquid2.CompareTag("Acid"))
        {
            result = Instantiate(Resources.Load<GameObject>("Effects/Smoke"));
            Debug.Log("Произошла реакция нейтрализации!");
        }
        else
        {
            result = null;
        }
    }

    public void HeatObject(GameObject obj, float temperature)
    {
        if (obj.CompareTag("Flammable") && temperature > 100)
        {
            Instantiate(Resources.Load<GameObject>("Effects/Fire"));
        }
    }
}

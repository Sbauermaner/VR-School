using UnityEngine;

[System.Serializable]
public class LessonStep
{
    public enum StepType { Text, Video, Model, Quiz }
    public StepType type;
    public string content; // Текст или путь к ресурсу
    public Vector3 modelPosition; // Позиция 3D-модели
    public Quaternion modelRotation; // Поворот 3D-модели
}

[System.Serializable]
public class MicroLesson
{
    public string lessonId;
    public string title;
    public string topic;
    public float duration; // в минутах
    public LessonType type; // Quiz, Flashcards, Simulation
    public string contentPath; // путь к JSON/префабу

    public enum LessonType { Quiz, Flashcards, Simulation }
}

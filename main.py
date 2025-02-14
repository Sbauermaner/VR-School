from badges.badge_manager import create_default_badges
from assistants import initialize_assistants
from ai_integration.ai_modeling import run_ai_modeling
from dashboard.dashboard import Dashboard

def main():
    print("Добро пожаловать в VR School Project!")

    # Значки
    badges = create_default_badges()
    for badge in badges:
        print(badge.display_info())
        print(badge.upgrade_level())
    
    # Ассистенты
    assistants = initialize_assistants()
    for assistant in assistants:
        print(assistant.assist("обучение в VR"))

    # ИИ-моделирование
    print("Идёт генерация сценария...")
    print(run_ai_modeling())

    # Дашборд
    student_dashboard = Dashboard("Иван")
    student_dashboard.schedule.add_to_schedule("Математика", "09:00")
    student_dashboard.biometrics.update_physical_state("Пульс", "72 уд/мин")
    student_dashboard.neuro.update_neural_impulses("alpha", 50)
    print(student_dashboard.display_dashboard())

if __name__ == "__main__":
    main()

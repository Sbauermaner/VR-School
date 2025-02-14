class AIAssistant:
    def __init__(self, name):
        self.name = name

    def assist(self, task):
        return f"{self.name} (ИИ) помогает с {task}"

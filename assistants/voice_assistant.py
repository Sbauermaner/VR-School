class VoiceAssistant:
    def __init__(self, name):
        self.name = name

    def assist(self, task):
        return f"{self.name} помогает с {task}"

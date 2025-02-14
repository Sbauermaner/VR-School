class Badge:
    def __init__(self, name, description, level=1):
        self.name = name
        self.description = description
        self.level = level

    def display_info(self):
        return f"{self.name} (Уровень {self.level}): {self.description}"

    def upgrade_level(self):
        self.level += 1
        return f"Уровень значка {self.name} повышен до {self.level}"

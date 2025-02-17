class ScheduleManager:
    def __init__(self):
        self.schedule = {}

    def add_to_schedule(self, subject, time):
        self.schedule[time] = subject
        return f"Добавлено: {subject} в {time}"

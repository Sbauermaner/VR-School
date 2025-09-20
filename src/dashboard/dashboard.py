from .schedule import ScheduleManager
from .biometrics import BiometricsTracker
from .neuro_monitor import NeuroMonitor

class Dashboard:
    def __init__(self, username):
        self.username = username
        self.schedule = ScheduleManager()
        self.biometrics = BiometricsTracker()
        self.neuro = NeuroMonitor()

    def display_dashboard(self):
        return f"""
        Дашборд для {self.username}
        Расписание: {self.schedule.schedule}
        Биометрия: {self.biometrics.metrics}
        Нейроимпульсы: {self.neuro.impulses}
        """

class NeuroMonitor:
    def __init__(self):
        self.impulses = {}

    def update_neural_impulses(self, wave_type, value):
        self.impulses[wave_type] = value
        return f"Обновлено: {wave_type} = {value}"

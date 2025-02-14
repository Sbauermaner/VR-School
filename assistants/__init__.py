from .voice_assistant import VoiceAssistant
from .ai_assistant import AIAssistant

def initialize_assistants():
    return [
        VoiceAssistant("Алиса"),
        AIAssistant("VR Tutor")
    ]

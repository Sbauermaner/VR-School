using System;

[Serializable]
public class OpenAIRequest
{
    public string model;
    public Message[] messages;

    [Serializable]
    public class Message
    {
        public string role;
        public string content;
    }
}

using System.Collections.Generic;
using UnityEngine;

public class FlashcardSystem : MonoBehaviour
{
    public List<Flashcard> currentDeck = new List<Flashcard>();

    public void LoadDeck(string path)
    {
        TextAsset deckFile = Resources.Load<TextAsset>(path);
        currentDeck = JsonUtility.FromJson<FlashcardDeck>(deckFile.text).cards;
    }

    public Flashcard GetNextCard()
    {
        if (currentDeck.Count == 0) return null;
        Flashcard card = currentDeck[0];
        currentDeck.RemoveAt(0);
        return card;
    }

    [System.Serializable]
    private class FlashcardDeck
    {
        public List<Flashcard> cards;
    }
}

[System.Serializable]
public class Flashcard
{
    public string term;
    public string definition;
    public string imagePath; // опционально
}

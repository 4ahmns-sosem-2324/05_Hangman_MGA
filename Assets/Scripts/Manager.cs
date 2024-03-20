using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Manager : MonoBehaviour
{
    public Wordlist wordlist;
    // Methode zur Auswahl eines zufälligen Worts aus dem Array und Rückgabe als String
    string GetRandomWord(string[] wordArray)
    {
        // Generiere einen zufälligen Index
        int randomIndex = Random.Range(0, wordArray.Length);

        // Gib das zufällige Wort basierend auf dem generierten Index zurück
        return wordArray[randomIndex];
    }

    void Start()
    {
        Debug.Log(GetRandomWord(wordlist.words5));
        Debug.Log(GetRandomWord(wordlist.words10));
        Debug.Log(GetRandomWord(wordlist.words100));
    }
}

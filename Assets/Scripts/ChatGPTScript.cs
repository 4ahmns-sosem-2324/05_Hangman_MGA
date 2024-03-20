using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChatGPTScript : MonoBehaviour
{
    // Eine Liste von Wörtern für das Spiel
    private string[] words = { "hangman", "computer", "programming", "csharp", "developer", "game" };

    // Zufallsgenerator
    private System.Random random = new System.Random();

    // Zufällig ausgewähltes Wort
    private string wordToGuess;

    // Array zur Speicherung des aktuellen Zustands des geratenen Wortes
    private char[] guessedWord;

    // Variable, um den Spielzustand zu verfolgen (ob das Wort geraten wurde)
    private bool wordGuessed = false;

    // Variable zur Verfolgung der Anzahl der Versuche
    private int attempts = 0;

    // Start is called before the first frame update
    void Start()
    {
        // Zufällige Auswahl eines Wortes aus der Liste
        wordToGuess = words[random.Next(words.Length)];

        // Initialisierung des geratenen Wortes mit Unterstrichen
        guessedWord = new char[wordToGuess.Length];
        for (int i = 0; i < wordToGuess.Length; i++)
        {
            guessedWord[i] = '_';
        }

        // Willkommensnachricht
        Debug.Log("Willkommen beim Hangman-Spiel!");
        Debug.Log("Errate das Wort:");
    }

    // Update is called once per frame
    void Update()
    {
        // Schleife, die das Spiel steuert, bis das Wort geraten wurde
        if (!wordGuessed)
        {
            // Anzeigen des aktuellen Zustands des geratenen Wortes
            Debug.Log("Aktuelles Wort: " + new string(guessedWord));
            Debug.Log("Gib einen Buchstaben ein:");

            // Überprüfung, ob ein Buchstabe eingegeben wurde
            if (Input.anyKeyDown)
            {
                char guessedLetter = Input.inputString.ToLower()[0];

                // Überprüfung, ob der geratene Buchstabe im Wort enthalten ist
                bool letterFound = false;
                for (int i = 0; i < wordToGuess.Length; i++)
                {
                    if (wordToGuess[i] == guessedLetter)
                    {
                        // Wenn der Buchstabe gefunden wurde, aktualisiere das geratene Wort
                        guessedWord[i] = guessedLetter;
                        letterFound = true;
                    }
                }

                // Wenn der Buchstabe nicht im Wort enthalten ist, erhöhe die Anzahl der Versuche
                if (!letterFound)
                {
                    attempts++;
                    Debug.Log("Falsch geraten! Versuche es erneut.");
                }

                // Überprüfen, ob das Wort vollständig geraten wurde
                if (new string(guessedWord) == wordToGuess)
                {
                    wordGuessed = true;
                }
            }
        }
        else
        {
            // Ausgabe einer Glückwunschnachricht und der Anzahl der Versuche
            Debug.Log("Glückwunsch! Du hast das Wort \"" + wordToGuess + "\" erraten.");
            Debug.Log("Du hast " + attempts + " Versuche gebraucht.");
        }
    }
}
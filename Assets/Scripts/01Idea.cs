using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Idea : MonoBehaviour
{
    /*
     Canvas Anlegen-> 960x600
     Gamemaster mit Script für die Gamelogic-> GamemasterScript
    Mit Unity AI-> nutzen als Wortgenerator-> da auf Sprache (De/En/etc. achten)-> hier werden die Wörter generiert 
    Mit Unity 2D-Elemete für Hangman erstellen-> bei Falscher Eingabe einblenden
    In Canvas dann "_ _ …" für die Wörter anlegen-> Diese Verändern sich mit der Wortlänge
    Bei Richtiger Tastatureingabe-> Die Buchstaben werden an der richtigen Stelle eingefügt
    Bei Falscher -//- -> Die Hangmanteile werden eingeblendet
    Bei "Loose" -> u Died Screen
    Bei "Win"-> WinnerWinnerChickenDinner Screen
    Benötigte Elemete: 

    --------------------
    Scripting: Mit ChatGPT und CoPilot -> Um die AI LogicScripts für Unity zu erstellen
    UI: In Unity über Sprites(?) machen als einzelne GO und dann nach Bedarf einblenden
    Export: als WebGl ->Unity 2D

    Benennung: 05-Hangman-MGaisberger
    --------------------
    Wichtige Schritte:
    GitHub Repo anlegen... Mermaid Diagramm erstellen!
    Dann wieder in die "Klassengruppe" freigeben

    -----------------------
    C#-Code (!nicht Unity c#):
    using System;

class Hangman
{
    static void Main(string[] args)
    {
        string[] words = { "hangman", "computer", "programming", "csharp", "developer", "game" };
        Random random = new Random();
        string wordToGuess = words[random.Next(words.Length)];
        char[] guessedWord = new char[wordToGuess.Length];

        // Initialisierung des geratenen Wortes mit Unterstrichen
        for (int i = 0; i < wordToGuess.Length; i++)
        {
            guessedWord[i] = '_';
        }

        bool wordGuessed = false;
        int attempts = 0;

        Console.WriteLine("Willkommen beim Hangman-Spiel!");
        Console.WriteLine("Errate das Wort:");

        while (!wordGuessed)
        {
            Console.WriteLine("Aktuelles Wort: " + string.Join(" ", guessedWord));
            Console.Write("Gib einen Buchstaben ein: ");
            char guessedLetter = char.ToLower(Console.ReadKey().KeyChar);
            Console.WriteLine();

            bool letterFound = false;

            for (int i = 0; i < wordToGuess.Length; i++)
            {
                if (wordToGuess[i] == guessedLetter)
                {
                    guessedWord[i] = guessedLetter;
                    letterFound = true;
                }
            }

            if (!letterFound)
            {
                attempts++;
                Console.WriteLine("Falsch geraten! Versuche es erneut.");
            }

            if (new string(guessedWord) == wordToGuess)
            {
                wordGuessed = true;
            }
        }

        Console.WriteLine("Glückwunsch! Du hast das Wort \"{0}\" erraten.", wordToGuess);
        Console.WriteLine("Du hast {0} Versuche gebraucht.", attempts);
    }
}

    ________________________________
    Nur die Kommentierte Version:
    Eine Liste von Wörtern für das Spiel
    Erstellen eines Zufallsgenerators
    Zufällige Auswahl eines Wortes aus der Liste
    Ein Array, um den aktuellen Zustand des geratenen Wortes zu speichern
    Initialisierung des geratenen Wortes mit Unterstrichen
    Variable, um den Spielzustand zu verfolgen (ob das Wort geraten wurde)
    Variable zur Verfolgung der Anzahl der Versuche
    Willkommensnachricht
    Schleife, die das Spiel steuert, bis das Wort geraten wurde
    Anzeigen des aktuellen Zustands des geratenen Wortes
    Einlesen eines Buchstabens vom Benutzer
    Überprüfung, ob der geratene Buchstabe im Wort enthalten ist
    Wenn der Buchstabe gefunden wurde, aktualisiere das geratene Wort
    Wenn der Buchstabe nicht im Wort enthalten ist, erhöhe die Anzahl der Versuche
    Überprüfen, ob das Wort vollständig geraten wurde
    Ausgabe einer Glückwunschnachricht und der Anzahl der Versuche



     */
}

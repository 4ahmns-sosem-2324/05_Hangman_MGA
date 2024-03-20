using UnityEngine;
using TMPro;
using System.Collections.Generic;

public class HangmanController : MonoBehaviour
{
    public TMP_InputField inputField;
    public TextMeshProUGUI wordDisplay;
    public TextMeshProUGUI wrongLettersText;
    public TextMeshProUGUI remainingTriesText;

    private List<string> words = new List<string>()
    {
        "abandoniert", "abend", "abenteuer", "abhängig", "abhol", "abkehr", "abkürzung", "ablehnung", "abmahn", "abnutzung",
        "abonnenten", "abonnement", "abrechnung", "abreise", "abreiß", "abriss", "abschied", "abseits", "absprachen", "abstimmung",
        "absturz", "abteilung", "abtreibung", "abwendung", "abwehr", "abwicklung", "abzock", "abzugsbegriff", "achter", "achterbahn",
        "achterdeck", "achten", "achtung", "adler", "adapter", "advent", "agent", "aktien", "aktion", "aktionswort",
        "aktivierung", "aktivität", "akzeptanz", "akzent", "alarm", "alkohol", "allerbeste", "allerdings", "allerlei", "allgemein",
        "allmählich", "alltags", "allwissend", "alphabet", "altart", "alter", "alternativ", "amateur", "ambulant", "ambulanz",
        "amerika", "amt", "anarchie", "anatomie", "anbau", "anbieter", "andacht", "anders", "andrang", "aneignung",
        "anerkennung", "anfang", "anfechtung", "anforderungs", "anführer", "angebot", "anglizismen", "angriff", "anhang", "anhebung",
        "anhörung", "animaux", "animation", "anlage", "anleger", "anleitung", "anmerkungs", "anordnung", "anruf", "ansatz",
        "anschlag", "anschluss", "ansicht", "anspruch", "anstieg", "anstrengung", "antrags", "antriebs", "anweisung", "anzeige",
        "anzug", "apfel", "apotheker", "app", "april", "archiv", "armband", "armut", "arrangement", "artikel",
        "art", "aspekt", "asphalt", "assistent", "asyl", "athlet", "attraktions", "aufbaus", "aufbewahrungs", "aufbruch",
        "aufenthalt", "aufgabe", "aufhebung", "aufklärung", "auflösung", "aufnahme", "aufnahmeprüfung", "aufprall", "aufregung", "aufreger",
        "aufregung", "aufruf", "aufschwung", "aufsehen", "aufsicht", "aufstieg", "auftrag", "auftraggeber", "auftakt", "auftreten",
        "aufwand", "aufzeichnung", "aufzucht", "augenarzt", "augenblick", "ausarbeitung", "ausbau", "ausblick", "ausbreitung", "ausbruch",
        "ausdruck", "ausführung", "ausgabe", "ausgangspunkt", "ausgabe", "ausgrenzung", "auskunft", "auslage", "ausland", "auslese",
        "auslese", "auslieferung", "ausnahme", "ausreiß", "aussage", "ausschluss", "aussicht", "aussiedler", "aussicht", "austausch",
        "austausch", "auster", "auswahl", "auswanderer", "ausweis", "auswertung", "auszahlung", "auszeichnung", "auszug", "autofahr",
        "autofahrer", "automat", "autoren", "autoritäts", "autor", "autoverkäufer", "autoverkäufer", "außergewöhnlich", "backofen",
        "badezimmer", "badewannen", "bahn", "bahnarbeiter", "bahnarbeiter", "bahnarbeiter", "bahnhofs", "bahnsteig", "balancier", "ballon",
        "band", "banken", "bankier", "bankrott", "bargeld", "baron", "barrierefrei", "basis", "batterie", "bauer",
        "bauernhof", "bauer", "bauer", "baufahrzeug", "baufahrzeug", "baufahrzeug", "baufahrzeug", "bauernhaus", "bauleiter", "bauleitung",
        "baum", "baumwoll", "baustein", "bauträger", "bauunternehmer", "bauvorschrift", "bauwerk", "bayern", "beamtenschaft", "beantragung",
        "bedeutungs", "bedienungs", "bedingungs", "bedrohungs", "befehls", "befeuerungs", "befragungs", "begräbnis", "begriffs", "begründungs",
        "begutachtungs", "behälter", "behälter", "behörden", "beifahrer", "beigabe", "beilage", "beilegungs", "beisitzer"
    };

    private string secretWord; // Das zu erratende Wort
    private string displayedWord; // Das aktuell angezeigte Wort
    private List<char> wrongLetters = new List<char>(); // Liste der falschen Buchstaben
    private int remainingTries = 10; // Anzahl der verbleibenden Versuche

    void Start()
    {
        SelectRandomWord();
        InitializeDisplayedWordWithPlaceholders();
        Debug.Log("Secret Word: " + secretWord);
        wordDisplay.text = displayedWord;
        UpdateRemainingTriesText();
        inputField.onSubmit.AddListener(OnSubmit);
    }

    void SelectRandomWord()
    {
        int randomIndex = Random.Range(0, words.Count);
        secretWord = words[randomIndex].ToUpper(); // Wähle ein zufälliges Wort aus der Liste
    }

    void InitializeDisplayedWordWithPlaceholders()
    {
        displayedWord = "";
        for (int i = 0; i < secretWord.Length; i++)
        {
            displayedWord += "_ ";
        }
    }

    void OnSubmit(string input)
    {
        char letter = input.ToUpper()[0]; // Ersten Buchstaben der Eingabe überprüfen (ignoriert Groß-/Kleinschreibung)
        bool found = false;

        // Überprüfen, ob der eingegebene Buchstabe im geheimen Wort vorkommt
        for (int i = 0; i < secretWord.Length; i++)
        {
            if (secretWord[i] == letter)
            {
                found = true;
                displayedWord = displayedWord.Substring(0, i * 2) + letter + displayedWord.Substring(i * 2 + 1);
            }
        }

        // Update des angezeigten Worts
        wordDisplay.text = displayedWord;

        if (!found)
        {
            // Hinzufügen des falschen Buchstabens zur Liste und Aktualisieren des Textes
            AddWrongLetter(letter);
            Debug.Log("Buchstabe nicht gefunden!");
            // Einen Versuch abziehen
            SubtractTry();
        }
    }

    void AddWrongLetter(char letter)
    {
        if (!wrongLetters.Contains(letter))
        {
            wrongLetters.Add(letter);
            UpdateWrongLettersText();
        }
    }

    void UpdateWrongLettersText()
    {
        wrongLettersText.text = "Wrong Letters: ";
        foreach (char letter in wrongLetters)
        {
            wrongLettersText.text += letter + " ";
        }
        if (remainingTries == 0)
        {
            // Alle Versuche aufgebraucht, deaktiviere das Eingabefeld und zeige "You Lose" an
            inputField.interactable = false;
            remainingTriesText.text = "And Now Failure....";
        }
    }

    void SubtractTry()
    {
        remainingTries--;
        UpdateRemainingTriesText();
    }

    void UpdateRemainingTriesText()
    {
        remainingTriesText.text = "Remaining Tries: " + remainingTries;
    }


}

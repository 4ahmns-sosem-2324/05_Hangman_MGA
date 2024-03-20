using UnityEngine;

public class WordPicker : MonoBehaviour
{
    // Methode zur Auswahl eines zufälligen Wortes aus dem Array
    string PickRandomWord(string[] wordArray)
    {
        // Erstellen eines Zufallsgenerators
        System.Random random = new System.Random();

        // Zufällige Auswahl eines Indexes im Bereich des Arrays
        int randomIndex = random.Next(0, wordArray.Length);

        // Rückgabe des ausgewählten Wortes
        return wordArray[randomIndex];
    }

    void Start()
    {
        
        string[] words = { "Hangman", "Computer", "Programming", "CSharp", "Developer" };
        string randomWord = PickRandomWord(words);
        Debug.Log("Zufällig ausgewähltes Wort: " + randomWord);
    }

}



public class WordListPrinter : MonoBehaviour
{
    // Array mit 5 Wörtern
    private string[] words5 = { "Apple", "Banana", "Orange", "Pineapple", "Grapes" };

    // Array mit 10 Wörtern
    private string[] words10 = { "Car", "Bus", "Train", "Bicycle", "Motorcycle", "Truck", "Boat", "Plane", "Helicopter", "Subway" };

    // Array mit 100 Wörtern
    private string[] words100 = {
        "Hello", "World", "Unity", "Game", "Programming", "Developer", "OpenAI", "Artificial", "Intelligence", "Machine",
        "Learning", "Robotics", "Algorithm", "Data", "Structure", "Algorithm", "Object", "Oriented", "Programming", "Software",
        "Engineering", "Computer", "Science", "Python", "Java", "CSharp", "JavaScript", "HTML", "CSS", "React", "Vue",
        "Angular", "Database", "SQL", "MySQL", "PostgreSQL", "MongoDB", "Firebase", "Node", "Express", "API", "Framework",
        "Web", "Mobile", "Desktop", "Application", "Cloud", "Computing", "Internet", "Things", "Blockchain", "Cryptocurrency",
        "Bitcoin", "Ethereum", "Smart", "Contract", "Decentralized", "Finance", "DeFi", "NFT", "Metaverse", "Virtual",
        "Reality", "Augmented", "AR", "VR", "Gaming", "Console", "PC", "PlayStation", "Xbox", "Nintendo", "Switch",
        "Steam", "Epic", "Store", "Indie", "Publisher", "Developer", "Gameplay", "Graphics", "Audio", "Design", "UI", "UX",
        "QA", "Testing", "Release", "Version", "Control", "Git", "GitHub", "Bitbucket", "Repository", "Merge", "Conflict",
        "Branch", "Pull", "Request", "Issue", "Bug", "Feature", "Documentation", "Readme"
    };

    void Start()
    {
        // Ausgabe eines zufälligen Wortes aus jedem Array
        Debug.Log("Ein zufälliges Wort aus dem Array mit 5 Wörtern: " + words5[Random.Range(0, words5.Length)]);
        Debug.Log("Ein zufälliges Wort aus dem Array mit 10 Wörtern: " + words10[Random.Range(0, words10.Length)]);
        Debug.Log("Ein zufälliges Wort aus dem Array mit 100 Wörtern: " + words100[Random.Range(0, words100.Length)]);
    }
}

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Wordlist : MonoBehaviour
{
    
    // Array mit 5 Wörtern
    public string[] words5 = { "Apple", "Banana", "Orange", "Pineapple", "Grapes" };

    // Array mit 10 Wörtern
    public string[] words10 = { "Car", "Bus", "Train", "Bicycle", "Motorcycle", "Truck", "Boat", "Plane", "Helicopter", "Subway" };

    internal string GetRandomWord()
    {
        throw new NotImplementedException();
    }

    // Array mit 100 Wörtern
    public string[] words100 = {
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
}

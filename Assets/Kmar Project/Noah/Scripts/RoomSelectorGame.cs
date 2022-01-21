using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;
using UnityEngine.SceneManagement;


public class RoomSelectorGame : MonoBehaviour
{
    public string selectedLevel;
    public Text onScreenSelectedLevelDisplay;

    public void Awake()
    {
        selectedLevel = "Makkelijk";
        onScreenSelectedLevelDisplay.text = string.Format("Moeilijkheidsgraad: Makkelijk");
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void CommanderLevel()
    {
        selectedLevel = ("Commander");
        onScreenSelectedLevelDisplay.text = string.Format("Moeilijkheidsgraad: Commander");
    }
    public void TestLevel()
    {
        selectedLevel = ("Test");
        onScreenSelectedLevelDisplay.text = string.Format("Moeilijkheidsgraad: Test");

    }

    public void FirstLevel()
    {
        selectedLevel = ("Makkelijk");
        onScreenSelectedLevelDisplay.text = string.Format("Moeilijkheidsgraad: Makkelijk");
    }

    public void SecondLevel()
    {
        selectedLevel = ("Gemiddeld");
        onScreenSelectedLevelDisplay.text = string.Format("Moeilijkheidsgraad: Gemiddeld");
    }
    public void ThirdLevel()
    {
        selectedLevel = ("Moeilijk");
        onScreenSelectedLevelDisplay.text = string.Format("Moeilijkheidsgraad: Moeilijk");
    }
    public void TutorialLevel()
    {
        selectedLevel = ("Tutorial");
        onScreenSelectedLevelDisplay.text = string.Format("Moeilijkheidsgraad: Tutorial");
    }

    public void StartGame()
    {
        SceneManager.LoadScene(selectedLevel);
    }

}

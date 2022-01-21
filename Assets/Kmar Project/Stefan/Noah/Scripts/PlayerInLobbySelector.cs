using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;


public class PlayerInLobbySelector : MonoBehaviour
{
    public Text currentRole;

    public Text moeilijkHeidsGraad;

    public bool commanderB;
    public bool breacherB;

    public GameObject currentRoleSprite;
    public GameObject commander;
    public GameObject breacher;

    public GameObject difficultyGmobj;

    public GameObject lobbyUIRoom;

    public void Awake()
    {
        commanderB = false;
        breacherB = true;
    }
    // Start is called before the first frame update
    void Start()
    {
        CheckRole();   
    }

    // Update is called once per frame
    void FixedUpdate()
    {
       
    }

    public void CheckRole()
    {
        if (breacherB == true)
        {
            currentRole.text = "Breacher";
            commanderB = false;
            currentRoleSprite.GetComponent<Image>().sprite = breacher.GetComponent<Image>().sprite;
        }
        if (commanderB == true)
        {
            currentRole.text = "Commander";
            breacherB = false;
        }
    }

    public void ArrowClick()
    {
        Debug.Log("Clicked");
        if(breacherB == true)
        {
            breacherB = false;
            commanderB = true;
            CheckRole();
            difficultyGmobj.SetActive(false);
            currentRoleSprite.GetComponent<Image>().sprite = commander.GetComponent<Image>().sprite;
            lobbyUIRoom.GetComponent<RoomSelectorGame>().CommanderLevel();
            return;
        }
        if (commanderB == true)
        {
            commanderB = false;
            breacherB = true;
            CheckRole();
            difficultyGmobj.SetActive(true);
            currentRoleSprite.GetComponent<Image>().sprite = breacher.GetComponent<Image>().sprite;
            lobbyUIRoom.GetComponent<RoomSelectorGame>().FirstLevel();
            return;
        }
    }

}

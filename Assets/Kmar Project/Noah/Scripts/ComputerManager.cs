using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ComputerManager : MonoBehaviour
{
    public GameObject logInMenu;
    public GameObject desktopMenu;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void logInButton()
    {
        logInMenu.SetActive(false);
        desktopMenu.SetActive(true);
    }
}

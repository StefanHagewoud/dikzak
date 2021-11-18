using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MenuScript : MonoBehaviour
{
    // Start is called before the first frame update
    // public Scene level1;
    public GameObject mainMenu;
    public GameObject settingsMenu;
    public GameObject levelSelectMenu;


    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ButtonPressed(Button button)
    {
        if (button.gameObject.name == "Settings")
        {
            waiter(1);
            mainMenu.SetActive(false);
            settingsMenu.SetActive(true);
            levelSelectMenu.SetActive(false);
        }
        else if (button.gameObject.name == "Back")
        {
            mainMenu.SetActive(true);
            settingsMenu.SetActive(false);
            levelSelectMenu.SetActive(false);
        }
        else if (button.gameObject.name == "Play")
        {
            mainMenu.SetActive(false);
            settingsMenu.SetActive(false);
            levelSelectMenu.SetActive(true);
        }
    }

    public IEnumerator waiter(int seconds)
    {
        yield return new WaitForSecondsRealtime(seconds);
    }

    public void StartLevel()
    {
        SceneManager.LoadScene("level1");
    }
}

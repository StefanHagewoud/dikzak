using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TransitionScript : MonoBehaviour
{
    // public GameObject otherCanvas;
    // Start is called before the first frame update
    // public AnimationClip clip;
    public AnimationClip clip;
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

    public void Transition()
    {
        var animation = GetComponent<Animation>();
        animation.clip = clip;
        animation.Play();
    }

    public void Start2(Button button)
    {
        Transition();
        StartCoroutine(setActive(button));
    }

    IEnumerator setActive(Button button)
    {
        yield return new WaitForSecondsRealtime(0.5f);
        if (button.gameObject.name == "Settings")
        {
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
}

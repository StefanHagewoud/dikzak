using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

public class ButtonScriptDifficulty : MonoBehaviour
{
    public GameObject startLevel;
    public Animator buttonAnimator;

    public GameObject rightButton;
    public GameObject leftButton;

    public float enableTime;

    // Start is called before the first frame update
    void Start()
    {
        buttonAnimator = gameObject.GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void RightButtonPressed()
    {
        startLevel.SetActive(false);
        buttonAnimator.Play("Pressed");
        rightButton.SetActive(false);
        leftButton.SetActive(true);
    }

    public void LeftButtonPressed()
    {
        buttonAnimator.SetTrigger("ButtonPressed");
        leftButton.SetActive(false);
        rightButton.SetActive(true);
        StartCoroutine(StartEnable());
    }

    IEnumerator StartEnable()
    {
        yield return new WaitForSeconds(enableTime);
        startLevel.SetActive(true);
    }
}

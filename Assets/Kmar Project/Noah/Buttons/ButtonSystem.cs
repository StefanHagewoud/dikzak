using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonSystem : MonoBehaviour
{
    [Header("Button Settings")]
    public List<GameObject> buttons;

    public List<GameObject> trueAndFalse;

    [Header("Code Settings")]
    public int codeToEnter;
    public int randomNumberForCode;
    public string enteredCode;
    public Text randomCodeText;

    public GameObject buttonsGameobject;

    void Swap()
    {
        for (int i = 0; i <= buttons.Count - 1; i++)
        {
            Vector3 temp = buttons[i].transform.position;
            int randomNumber = Random.Range(0, 9);
            buttons[i].transform.position = buttons[randomNumber].transform.position;
            buttons[randomNumber].transform.position = temp;
        }
    }

    public void Awake()
    {
        //Finds all buttons in scene and puts them in a List
        buttons.AddRange(GameObject.FindGameObjectsWithTag("Buttons"));

        randomNumberForCode = Random.Range(1, 5);
        randomCodeText.text = randomNumberForCode.ToString();
    }
    // Start is called before the first frame update
    void Start()
    {
        CheckWhichCode();

        //Swaps Random Buttons
        Swap();
    }

    public void Submit()
    {
        if (enteredCode == codeToEnter.ToString())
        {
            Debug.Log("Correct");
            buttonsGameobject.SetActive(false);
        }
        else
        {
            Debug.Log("Incorrect!");
        }
    }

    public void CheckWhichCode()
    {
        if (randomNumberForCode == 1)
        {
            codeToEnter = 1234567890;
        }
        if (randomNumberForCode == 2)
        {
            codeToEnter = 1054982736;
        }
        if (randomNumberForCode == 3)
        {
            codeToEnter = 1874526903;
        }

        if (randomNumberForCode == 3)
        {
            codeToEnter = 1546893720;
        }
    }
}

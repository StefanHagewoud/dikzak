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
    public int randomCodeGenerator;
    public string enteredCode;

    void Swap()
    {
        for(int i = 0; i <= buttons.Count - 1; i++)
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
    }
    // Start is called before the first frame update
    void Start()
    {
        randomCodeGenerator = Random.Range(9999, 99999);

        //Swaps Random Buttons
        Swap();
    }

    public void Submit()
    {
        if(enteredCode == randomCodeGenerator.ToString())
        {
            Debug.Log("Correct");
        }
        else
        {
            Debug.Log("Incorrect!");
        }
    }

    // Update is called once per frame
    void Update()
    {

    }
}

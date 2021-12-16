using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonSystem : MonoBehaviour
{
    [Header("Button Settings")]
    public List<GameObject> buttons;

    [Header("Code Settings")]
    public int randomCodeGenerator;
    public string enteredCode;

    public void Awake()
    {
        //Finds all buttons in scene and puts them in a List
        buttons.AddRange(GameObject.FindGameObjectsWithTag("Buttons"));
    }
    // Start is called before the first frame update
    void Start()
    {
        randomCodeGenerator = Random.Range(9999, 99999);
    }

    public void Submit()
    {
        if(enteredCode == randomCodeGenerator.ToString())
        {
            Debug.Log("Correct");
        }
    }

    // Update is called once per frame
    void Update()
    {

    }
}

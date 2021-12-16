using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Buttons : MonoBehaviour
{
    public string number;

    public bool deleteButton;
    public bool submitButton;

    public GameObject buttonPanel;

    // Start is called before the first frame update
    void Start()
    {
        //Checks if buttons is clicked
        var button = transform.GetComponent<Button>();
        button.onClick.AddListener(this.OnButtonClick);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnButtonClick()
    {

        if(deleteButton == true)
        {
            buttonPanel.GetComponent<ButtonSystem>().enteredCode = "";
            return;
        }

        if(submitButton == true)
        {
            buttonPanel.GetComponent<ButtonSystem>().Submit();
            return;
        }

        Debug.Log(number);
        GetComponentInParent<ButtonSystem>().enteredCode = GetComponentInParent<ButtonSystem>().enteredCode + number.ToString();
    }

}

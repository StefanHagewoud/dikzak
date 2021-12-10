using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CodeGenerator : MonoBehaviour
{
    public int number;
    public GameObject textBox;

    // Start is called before the first frame update
    public void Start()
    {
        number = Random.Range(1, 10000);
        //textBox.GetComponent<Text>().text = "" + number;
        Debug.Log(number);
    }
}

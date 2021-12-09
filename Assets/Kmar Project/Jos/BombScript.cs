using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BombScript : MonoBehaviour
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

    // Update is called once per frame
    void Update()
    {
     
    }

    public void Button1()
    {
        textBox.GetComponent<Text>().text = "" + 1;
        Debug.Log(1);
    }
    public void Button2()
    {
        textBox.GetComponent<Text>().text = "" + 1;
        Debug.Log(1);
    }
}

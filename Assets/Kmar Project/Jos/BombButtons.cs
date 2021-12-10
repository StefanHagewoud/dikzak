using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BombButtons : MonoBehaviour
{
    public GameObject textBox;
    public void Button1()
    {
        textBox.GetComponent<Text>().text+= 1;
    }
    public void Button2()
    {
        textBox.GetComponent<Text>().text += 2;
    }
    public void Button3()
    {
        textBox.GetComponent<Text>().text += 3;
    }
    public void Button4()
    {
        textBox.GetComponent<Text>().text += 4;
    }
    public void Button5()
    {
        textBox.GetComponent<Text>().text += 5;
    }
    public void Button6()
    {
        textBox.GetComponent<Text>().text += 6;
    }
    public void Button7()
    {
        textBox.GetComponent<Text>().text += 7;
    }
    public void Button8()
    {
        textBox.GetComponent<Text>().text += 8;
    }
    public void Button9()
    {
        textBox.GetComponent<Text>().text += 9;
    }
    public void Button0()
    {
        textBox.GetComponent<Text>().text += 0; 
    }
    public void TerugButton()
    {
        textBox.GetComponent<Text>().text = "";
    }
    public void EnterButton()
    {
        if (textBox.GetComponent<Text>().text != "" + gameObject.GetComponent<CodeGenerator>().number)
        {
          Debug.Log("Verkeerde Code!");
          textBox.GetComponent<Text>().text = "";
        }
        if (textBox.GetComponent<Text>().text == "" + gameObject.GetComponent<CodeGenerator>().number)
        {
            Debug.Log("goede code ingevuld!");
            gameObject.GetComponent<BombTimer>().enabled = false;
        }
        //Debug.Log("EnterCode");
    }
    

}

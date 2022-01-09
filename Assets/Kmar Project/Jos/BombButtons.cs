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
          GameObject.Find("Timer").GetComponent<BombTimer>().timeValue -= 30;
        }
        if (textBox.GetComponent<Text>().text == "" + gameObject.GetComponent<CodeGenerator>().number)
        {
            Debug.Log("goede code ingevuld!");
            //GameObject.Find("Timer").GetComponent<BombTimer>().enabled = false;
            GetComponent<CodeGenerator>().puzzelCounter++;
            textBox.GetComponent<Text>().text = "";
            GameObject.Find("1").GetComponent<Button>().interactable = false;
            GameObject.Find("2").GetComponent<Button>().interactable = false;
            GameObject.Find("3").GetComponent<Button>().interactable = false;
            GameObject.Find("4").GetComponent<Button>().interactable = false;
            GameObject.Find("5").GetComponent<Button>().interactable = false;
            GameObject.Find("6").GetComponent<Button>().interactable = false;
            GameObject.Find("7").GetComponent<Button>().interactable = false;
            GameObject.Find("8").GetComponent<Button>().interactable = false;
            GameObject.Find("9").GetComponent<Button>().interactable = false;
            GameObject.Find("0").GetComponent<Button>().interactable = false;
            Destroy(this);
        }
    }
}

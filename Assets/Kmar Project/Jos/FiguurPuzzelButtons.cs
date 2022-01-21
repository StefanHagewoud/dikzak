using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FiguurPuzzelButtons : MonoBehaviour
{
    public Text awnserText;
    public void Button0()
    {
        awnserText.GetComponent<Text>().text += 0;
    }
    public void Button1()
    {
        awnserText.GetComponent<Text>().text += 1;
    }
    public void Button2()
    {
        awnserText.GetComponent<Text>().text += 2;
    }
    public void Button3()
    {
        awnserText.GetComponent<Text>().text += 3;
    }
    public void Button4()
    {
        awnserText.GetComponent<Text>().text += 4;
    }
    public void Button5()
    {
        awnserText.GetComponent<Text>().text += 5;
    }
    public void Button6()
    {
        awnserText.GetComponent<Text>().text += 6;
    }
    public void Button7()
    {
        awnserText.GetComponent<Text>().text += 7;
    }
    public void Button8()
    {
        awnserText.GetComponent<Text>().text += 8;
    }
    public void Button9()
    {
        awnserText.GetComponent<Text>().text += 9;
    }
    public void EnterButton()
    {
        if (awnserText.GetComponent<Text>().text != "" + GameObject.Find("Enter").GetComponent<FiguurPuzzelScript>().figuurCijfer)
        {
            awnserText.GetComponent<Text>().text = "";
            Debug.Log("Verkeerde Code ingevuld!");
        }
        if (awnserText.GetComponent<Text>().text == "" + GameObject.Find("Enter").GetComponent<FiguurPuzzelScript>().figuurCijfer)
        {
            Debug.Log("Goede Code Ingevuld!");
        }
    }
}

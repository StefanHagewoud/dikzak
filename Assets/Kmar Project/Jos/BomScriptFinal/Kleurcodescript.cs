using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Kleurcodescript : MonoBehaviour
{
    public GameObject textBOX;
    
    public void RodeKnop()
    {
        textBOX.GetComponent<Text>().text += 3;
    }

    public void OranjeKnop()
    {
        textBOX.GetComponent<Text>().text += 0;
    }

    public void GeleKnop()
    {
        textBOX.GetComponent<Text>().text += 4;
    }

    public void GroeneKnop()
    {
        textBOX.GetComponent<Text>().text += 1;
    }

    public void LichtblauweKnop()
    {
        textBOX.GetComponent<Text>().text += 5;
    }

    public void BlauweKnop()
    {
        textBOX.GetComponent<Text>().text += 2;
    }
    public void PaarseKnop()
    {
        textBOX.GetComponent<Text>().text += 6;
    }

    public void KleurCodeEnter()
    {
        if (textBOX.GetComponent<Text>().text != "" + gameObject.GetComponent<Puzzelbijhouder>().kleurCode)
        {
            textBOX.GetComponent<Text>().text = "";
            GameObject.Find("Timer").GetComponent<BombTimer>().timeValue -= 5;
        }

        if (textBOX.GetComponent<Text>().text == "" + gameObject.GetComponent<Puzzelbijhouder>().kleurCode)
        {
            Debug.Log("Goede Code ingevuld!!");
            textBOX.GetComponent<Text>().text = "";
            GameObject.Find("Enter").GetComponent<Puzzelbijhouder>().puzzelCounter++;
        }
    }
}


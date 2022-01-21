using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Kabelscriptje : MonoBehaviour
{
    public void RedWire()
    {
        Debug.Log("Goede draad!");
        Destroy(gameObject);
        GameObject.Find("Enter").GetComponent<Puzzelbijhouder>().puzzelCounter++;
    }
    public void GreenWire()
    {
        Destroy(gameObject);
        Debug.Log("verkeerde draad!");
        GameObject.Find("Timer").GetComponent<BombTimer>().timeValue -= 30;
    }
    public void YellowWire()
    {
        Destroy(gameObject);
        Debug.Log("verkeerde draad!");
        GameObject.Find("Timer").GetComponent<BombTimer>().timeValue -= 30;
    }
    public void PurpleWire()
    {
        Destroy(gameObject);
        Debug.Log("verkeerde draad!");
        GameObject.Find("Timer").GetComponent<BombTimer>().timeValue -= 30;
    }
    public void BlueWire()
    {
        Debug.Log("Goede draad!");
        Destroy(gameObject);
        GameObject.Find("Enter").GetComponent<Puzzelbijhouder>().puzzelCounter++;
    }
}

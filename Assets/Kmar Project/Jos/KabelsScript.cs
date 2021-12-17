using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KabelsScript : MonoBehaviour
{
    public int puzzelcounter;

    public void RedWire()
   { 
        Debug.Log("verkeerde draad!");
        Destroy(gameObject);
        GameObject.Find("Timer").GetComponent<BombTimer>().timeValue -= 30;
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
        Debug.Log("verkeerde draad!");
        Destroy(gameObject);
        GameObject.Find("Timer").GetComponent<BombTimer>().timeValue -= 30;
   }
    /////////////////////////////////////////////////////////////////////
    public void RooddraadGoed()
    {
        GetComponent<KabelsScript>().puzzelcounter++;
        Debug.Log("Goede draad!");
        gameObject.SetActive(false);
    }
    public void GroendraadGoed()
    {
        GetComponent<KabelsScript>().puzzelcounter++;
        Debug.Log("Goede draad!");
        gameObject.SetActive(false);
    }
    public void GeeldraadGoed()
    {
        GetComponent<KabelsScript>().puzzelcounter++;
        Debug.Log("Goede draad!");
        gameObject.SetActive(false);
    }
    public void PaarsdraadGoed()
    {
        GetComponent<KabelsScript>().puzzelcounter++;
        Debug.Log("Goede draad!");
        gameObject.SetActive(false);
    }
    public void BlauwdraadGoed()
    {
        GetComponent<KabelsScript>().puzzelcounter++;
        Debug.Log("Goede draad!");
        gameObject.SetActive(false);
    }
}

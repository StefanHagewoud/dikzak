using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KabelsScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        
    }

   public void RedWire()
   {
        Destroy(gameObject);
        Debug.Log("Goede draad!");
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
        Destroy(gameObject);
        Debug.Log("Goede draad!");
        GameObject.Find("Enter").GetComponent<BombButtons>().enabled = true;
    }



}

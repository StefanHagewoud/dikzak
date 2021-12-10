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

   }
   public void GreenWire()
   {
        Destroy(gameObject);
        Debug.Log("verkeerde draad!");
        GameObject.Find("Timer").GetComponent<BombTimer>().timeValue =-5;
   }
   public void YellowWire()
   {
        Destroy(gameObject);
        Debug.Log("verkeerde draad!");
   }
   public void PurpleWire()
   {
        Destroy(gameObject);
        Debug.Log("verkeerde draad!");
    }
   public void BlueWire()
   {

   }



}

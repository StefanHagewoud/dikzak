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
        Debug.Log("Goede draad!");
        Destroy(gameObject);
    }
    public void GroendraadGoed()
    {
        Debug.Log("Goede draad!");
        Destroy(gameObject);
    }
    public void GeeldraadGoed()
    {
        Debug.Log("Goede draad!");
        Destroy(gameObject);
    }
    public void PaarsdraadGoed()
    {
        Debug.Log("Goede draad!");
        Destroy(gameObject);
    }
    public void BlauwdraadGoed()
    {
        Debug.Log("Goede draad!");
        Destroy(gameObject);
       
    }
}

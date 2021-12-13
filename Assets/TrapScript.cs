using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrapScript : MonoBehaviour
{
    // Start is called before the first frame update
    public Transform point;
    public Camera camera1;
    public Camera camera2;
    public GameObject hostage;
    public GameObject hostage2;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnTriggerEnter(Collider other)
    {
        if (other.transform.parent.tag == "Karel")
        {
            other.transform.position = point.position;
            camera2.gameObject.SetActive(true);
            camera1.gameObject.SetActive(false);
        }
        if (hostage.GetComponent<HostageScript>().playerInRange == true)
        {
            hostage.SetActive(false);
            hostage2.SetActive(true);
        }
        if (hostage2.GetComponent<HostageScript>().playerInRange == true)
        {
            hostage.SetActive(true);
            hostage2.SetActive(false);
        }
    }
}

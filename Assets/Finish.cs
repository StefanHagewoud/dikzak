using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Finish : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject hostage;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

    }
    public void OnTriggerEnter(Collider other)
    {
        if (hostage.GetComponent<HostageScript>().playerInRange == true)
        {
            Application.Quit();
            Debug.Log("finish");
        }
    }
}

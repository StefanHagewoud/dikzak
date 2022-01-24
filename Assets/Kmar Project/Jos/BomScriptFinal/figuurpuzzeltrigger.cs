using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class figuurpuzzeltrigger : MonoBehaviour
{
    public GameObject figuurpuzzel;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == ("Player"))
        {
            figuurpuzzel.SetActive(true);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    
}

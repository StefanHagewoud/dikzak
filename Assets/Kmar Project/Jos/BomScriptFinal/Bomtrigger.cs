using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Bomtrigger : MonoBehaviour
{
    public GameObject bom;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            bom.SetActive(true);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

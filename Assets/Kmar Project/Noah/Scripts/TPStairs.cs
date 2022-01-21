using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class TPStairs : MonoBehaviour
{
    public Transform tpPosition;

    public GameObject breacher;
    public GameObject hostage;

    private void Awake()
    {
        breacher = GameObject.FindGameObjectWithTag("Player");
        hostage = GameObject.FindGameObjectWithTag("Hostage");
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.collider.tag == "Player")
        {
            collision.collider.gameObject.transform.position = tpPosition.transform.position;
            if(hostage.GetComponent<HostageScript>().playerInRange == true)
            {
                hostage.GetComponent<NavMeshAgent>().enabled = false;
                hostage.transform.position = hostage.GetComponent<HostageScript>().player.position;
                hostage.GetComponent<NavMeshAgent>().enabled = true;
            }
        }
    }
}

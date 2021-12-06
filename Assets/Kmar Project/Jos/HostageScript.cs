using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class HostageScript : MonoBehaviour
{
    public float health;

    public Vector3 destination;
    public NavMeshAgent agent;
    public Transform player;
    public bool playerInRange;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (playerInRange == true)
        {
            destination = player.position;
            agent.destination = destination;
        }
        
        
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            playerInRange = true;
        }
    }
}

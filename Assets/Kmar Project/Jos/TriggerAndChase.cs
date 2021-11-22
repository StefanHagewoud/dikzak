using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class TriggerAndChase : MonoBehaviour
{
    public Transform player;
    public bool spotted;
    public NavMeshAgent agent;
    public Vector3 destination;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (spotted == true)
        {
            destination = player.position;
            agent.destination = destination;
        }
    }
    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            spotted = true;
        }
    }
}

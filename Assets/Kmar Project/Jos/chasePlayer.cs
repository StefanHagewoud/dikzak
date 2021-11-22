using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class chasePlayer : MonoBehaviour
{
    public Vector3 destination;
    public Transform player;
    public NavMeshAgent agent;
    public GameObject cube;
    public bool spotted;
    public float searchTime;

    void Update()
    {
        if (spotted == false)
        {
            cube.SetActive(false);
            agent.destination = destination;
        }
        if (spotted == true)
        {
            cube.SetActive(true);
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
    void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            StartCoroutine(search());
        }
    }
    IEnumerator search()
    {
        yield return new WaitForSeconds(searchTime);
        spotted = false;
    }
}

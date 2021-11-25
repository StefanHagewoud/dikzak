using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PatrollScript : MonoBehaviour
{
    public Transform[] waypoints;
    public int speed;

    public float turnSpeed = 0.2f;
    Quaternion rotGoal;
    Vector3 direction;

    private int waypointIndex;
    private float dist;
    
    // Start is called before the first frame update
    void Start()
    {
        waypointIndex = 0;
        //transform.LookAt(waypoints[waypointIndex].position);
    }

    // Update is called once per frame
    void Update()
    {
        //transform.LookAt(waypoints[waypointIndex].position);
        direction = (waypoints[waypointIndex].position - transform.position).normalized;
        rotGoal = Quaternion.LookRotation(direction);
        transform.rotation = Quaternion.Slerp(transform.rotation, rotGoal, turnSpeed);

        dist = Vector3.Distance(transform.position, waypoints[waypointIndex].position);
        if(dist < 1f)
        {
            IncreaseIndex();
        }
        Patrol();
    }

    public void Patrol()
    {
        transform.Translate(Vector3.forward * speed * Time.deltaTime);
    }
    void IncreaseIndex()
    {
        waypointIndex++;
        if(waypointIndex >= waypoints.Length)
        {
            waypointIndex = 0;
        }
        //transform.LookAt(waypoints[waypointIndex].position);
    }
}

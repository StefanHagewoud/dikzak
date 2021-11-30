using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectScript : MonoBehaviour
{
    public bool detected;
    public GameObject target;
    public Transform enemy;
    public int health;

    //public Transform lookTarget;
    public float turnSpeed = 0.2f;
    Quaternion rotGoal;
    Vector3 direction;

    public GameObject bullet;
    public Transform shootPoint;

    public float shootSpeed = 10f;
    public float timeToShoot = 1.3f;
    float originalTime;

    // Start is called before the first frame update
    void Start()
    {
        originalTime = timeToShoot;
    }

    // Update is called once per frame
    void Update()
    {
        if (detected)
        {
            //GetComponent<Rigidbody>().constraints = RigidbodyConstraints.FreezePosition;
            GetComponent<PatrollScript>().enabled = false;
            //enemy.LookAt(target.transform);
            direction = (target.transform.position - transform.position).normalized;
            rotGoal = Quaternion.LookRotation(direction);
            transform.rotation = Quaternion.Slerp(transform.rotation, rotGoal, turnSpeed);
        }
    }

    private void FixedUpdate()
    {
        if (detected)
        {
            timeToShoot -= Time.deltaTime;

            if (timeToShoot < 0)
            {
                ShootPlayer();
                timeToShoot = originalTime;
            }
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            detected = true;
            target = other.gameObject;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.tag == "Player")
        {
            detected = false;
            GetComponent<PatrollScript>().enabled = true;
            //enemy.LookAt(patrolPoint.transform);
        }
    }

    private void ShootPlayer()
    {
        GameObject currentBullet = Instantiate(bullet, shootPoint.position, shootPoint.rotation);
        //Rigidbody rig = currentBullet.GetComponent<Rigidbody>();

        //rig.AddForce(transform.forward * shootSpeed, ForceMode.VelocityChange);
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class PlayerScript : MonoBehaviour
{
    public float horizontal;
    public float vertical;
    public Vector3 move;
    public float speed;

    public float health;
    

    // Update is called once per frame
    //movement
    void Update()
    {
        vertical = Input.GetAxis("Vertical");
        horizontal = Input.GetAxis("Horizontal");

        move.x = horizontal;
        move.z = vertical;

        GetComponent<Transform>().Translate(move * Time.deltaTime * speed);
    }
    
    //takeDamage
    public void TakeDamage(float amount)
    {
        health -= amount;
        if (health <= 0f)
        {
            //Destroy(gameObject);
            GameObject.Find("Enemy").GetComponent<PatrollScript>().enabled = true;
            GameObject.Find("Enemy").GetComponent<DetectScript>().enabled = false;
            Destroy(gameObject);
        }
    }
   
}

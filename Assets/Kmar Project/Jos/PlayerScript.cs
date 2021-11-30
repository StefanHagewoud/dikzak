using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class PlayerScript : MonoBehaviour
{
    public float horizontal;
    public float vertical;
    public Vector3 move; 
    public float speed;

    public float health = 100;
    

    // Update is called once per frame
    //movement
    void Update()
    {
        vertical = Input.GetAxis("Vertical");
        horizontal = Input.GetAxis("Horizontal");

        move.x = horizontal;
        move.z = vertical;

        GetComponent<Transform>().Translate(move * Time.deltaTime * speed);

        if(health<= 0)
        {
            Die();
        }
    }
    
    //takeDamage
    public void TakeDamage(float amount)
    {
        health -= amount;
        if (health <= 0f)
        {
            Die();
            Debug.Log("PlayerDied!");
        }
    }
    public void Die()
    {
        transform.position = new Vector3(45, 3, 46);
        GetComponent<PlayerScript>().enabled = false;
        //deadscreen/GameOverScreen aanzetten
    }
}

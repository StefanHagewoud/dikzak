using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public float damage = 50;
    public float speed = 20f;
    public float time = 2f;
    private float lifetimer;
    // Start is called before the first frame update
    void Start()
    {
        lifetimer = time;
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += transform.forward * speed * Time.deltaTime;

        lifetimer -= Time.deltaTime;
        if (lifetimer <= 0f)
        {
            Destroy(gameObject);
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            Debug.Log("HitPlayer!");
            other.transform.GetComponent<PlayerScript>().TakeDamage(damage = 50); 
        }
    }
}

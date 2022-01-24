using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Destroy : MonoBehaviour
{
    // Start is called before the first frame update
    public ParticleSystem blood;
    public ParticleSystem hit;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.tag == "Enemy")
        {
            Instantiate(blood, collision.transform.position, Quaternion.identity);
            Destroy(collision.gameObject);
            Destroy(this.gameObject);
        }
        else if (collision.collider.tag == "Player")
        {
            Instantiate(blood, collision.transform.position, Quaternion.identity);
            (collision.gameObject).GetComponent<PlayerController>().gameOverScreen.SetActive(true);
            Destroy(collision.gameObject);
            
            Destroy(this.gameObject);

        }
        else
        {
            Instantiate(hit, collision.transform.position, Quaternion.identity);
            Destroy(this.gameObject);
        }
    }
}

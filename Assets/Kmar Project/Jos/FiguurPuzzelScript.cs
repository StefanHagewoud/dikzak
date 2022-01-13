using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FiguurPuzzelScript : MonoBehaviour
{
    public Transform spawnlocation1;
    public Transform spawnlocation2;
    public GameObject[] figuren;
    // Start is called before the first frame update
    void Start()
    {
        Instantiate(figuren[Random.Range(0,figuren.Length)], spawnlocation1.position, spawnlocation1.rotation);
        Instantiate(figuren[Random.Range(0,figuren.Length)], spawnlocation2.position, spawnlocation1.rotation);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FiguurPuzzelScript : MonoBehaviour
{
    public Canvas canvas;
    public RectTransform spawnLocation1;
    public RectTransform spawnLocation2;
    public GameObject[] figuren;
    public GameObject[] figuren2;
    public Text awnserText;
    public string figuurCijfer;

    public void Start()
    {
        StartCoroutine(MyIEnumerator());
        Instantiate(figuren[Random.Range(0, figuren.Length)], spawnLocation1.transform);
        
        
        if (GameObject.FindGameObjectWithTag("Cube"))
        {
            figuurCijfer += 78;
        }
        if (GameObject.FindGameObjectWithTag("Sphere"))
        {
            figuurCijfer += 42;
        }
        if (GameObject.FindGameObjectWithTag("Cylinder"))
        {
            figuurCijfer += 13;
        }
        if (GameObject.FindGameObjectWithTag("Capsule"))
        {
            figuurCijfer += 56;
        }
    }

    IEnumerator MyIEnumerator()
    {
        yield return new WaitForSeconds(1);
        Instantiate(figuren2[Random.Range(0, figuren2.Length)], spawnLocation2.transform);
        
        if (GameObject.FindGameObjectWithTag("Kubus"))
        {
            figuurCijfer += 78;
        }
        if (GameObject.FindGameObjectWithTag("Bal"))
        {
            figuurCijfer += 42;
        }
        if (GameObject.FindGameObjectWithTag("Cilinder"))
        {
            figuurCijfer += 13;
        }
        if (GameObject.FindGameObjectWithTag("Capsulen"))
        {
            figuurCijfer += 56;
        }
    }
}

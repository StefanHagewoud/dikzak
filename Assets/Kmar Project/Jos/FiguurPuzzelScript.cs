using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FiguurPuzzelScript : MonoBehaviour
{
    public Canvas canvas;
    public RectTransform spawnLocation1;
    public RectTransform spawnLocation2;
    public RectTransform spawnLocation3;
    public GameObject[] figuren;
    public GameObject[] figuren2;
    public GameObject[] figuren3;
    public Text awnserText;
    public string figuurCijfer;

    public void Start()
    {
        StartCoroutine(MyIEnumerator());
        Instantiate(figuren[Random.Range(0, figuren.Length)], spawnLocation1.transform);
        
        if (GameObject.FindGameObjectWithTag("Square"))
        {
            figuurCijfer += 7;
        }
        if (GameObject.FindGameObjectWithTag("Triangle"))
        {
            figuurCijfer += 9;
        }
        if (GameObject.FindGameObjectWithTag("X"))
        {
            figuurCijfer += 3;
        }
        if (GameObject.FindGameObjectWithTag("cirkel"))
        {
            figuurCijfer += 5;
        }
    }

    IEnumerator MyIEnumerator()
    {
        StartCoroutine(MyIEnumerator2());

        yield return new WaitForSeconds(1);
        Instantiate(figuren2[Random.Range(0, figuren2.Length)], spawnLocation2.transform);

        if (GameObject.FindGameObjectWithTag("Vierkant"))
        {
            figuurCijfer += 7;
        }
        if (GameObject.FindGameObjectWithTag("Driehoek"))
        {
            figuurCijfer += 9;
        }
        if (GameObject.FindGameObjectWithTag("Xfiguur"))
        {
            figuurCijfer += 3;
        }
        if (GameObject.FindGameObjectWithTag("Rondje"))
        {
            figuurCijfer += 5;
        }
    }

    IEnumerator MyIEnumerator2()
    {
        yield return new WaitForSeconds(2);
        Instantiate(figuren3[Random.Range(0, figuren3.Length)], spawnLocation3.transform);

        if (GameObject.FindGameObjectWithTag("vier"))
        {
            figuurCijfer += 7;
        }
        if (GameObject.FindGameObjectWithTag("Drie"))
        {
            figuurCijfer += 9;
        }
        if (GameObject.FindGameObjectWithTag("Xje"))
        {
            figuurCijfer += 3;
        }
        if (GameObject.FindGameObjectWithTag("Rond"))
        {
            figuurCijfer += 5;
        }
    }
     
}

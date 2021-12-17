using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CodeGenerator : MonoBehaviour
{
    public GameObject geelgoededraad;
    public GameObject rooddraadgoed;
    public GameObject blauwdraadgoed;
    public GameObject groendraadgoed;
    public GameObject paarsdraadgoed;

    public bool puzzel1;
    public bool puzzel2;
    public bool puzzel3;

    public int number;
    public Text textBox;
    // Start is called before the first frame update
    public void Start()
    {
        //Debug.Log("Rood, Blauw");
        number = Random.Range(1, 10000);
        //textBox.GetComponent<Text>().text = "" + number;
        Debug.Log(number);

        string[] kabels = new string[] { "Geel", "Rood", "Blauw", "Paars", "Groen" };
        string randomName = kabels[Random.Range(0, 2)];
        //Debug.Log(randomName);

        string[] kabels1 = new string[] { "Geel", "Rood", "Blauw", "Paars", "Groen" };
        string randomName1 = kabels[Random.Range(3, kabels.Length)];
        Debug.Log(randomName);
        Debug.Log(randomName1);
        if (randomName == "Geel")
        {
            geelgoededraad.SetActive(true);
            Destroy(GameObject.Find("Geeldraad"));
        }

        if(randomName == "Rood")
        {
            rooddraadgoed.SetActive(true);
            Destroy(GameObject.Find("Rooddraad"));
        }

        if(randomName1 == "Paars")
        {
            paarsdraadgoed.SetActive(true);
            Destroy(GameObject.Find("Paarsdraad"));
        }

        if(randomName1 == "Groen")
        {
            groendraadgoed.SetActive(true);
            Destroy(GameObject.Find("Groendraad"));
        }

        if(randomName1 == "Blauw")
        {
            blauwdraadgoed.SetActive(true);
            Destroy(GameObject.Find("Blauwdraad"));
        }

        if (GameObject.Find("Wires").GetComponent<KabelsScript>().puzzelcounter == 2)
        {
            puzzel1 = true;
        }
    }
}

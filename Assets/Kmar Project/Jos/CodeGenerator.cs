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

    public int puzzelCounter;
    public bool[] puzzels;

    public int number;
    public int colorCode;
    public int colorCode1;
    public int colorCode2;
    public Text textBox;

    public void Start()
    {
        number = Random.Range(1, 10000);
        colorCode = Random.Range(1, 7);
        colorCode1 = Random.Range(1, 7);
        colorCode2 = Random.Range(1, 7);
    //textBox.GetComponent<Text>().text = "" + number;
        Debug.Log(number);
        Debug.Log(colorCode + colorCode1 + colorCode2);

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
    }
    public void Update()
    {
        if (puzzelCounter == 2)
        {
            for (int i = 0; i < puzzels.Length; i++)
            {
                if (puzzels[i] == false)
                {
                    puzzels[0] = true;
                    break;
                }
            }
        }

        if (puzzelCounter == 3)
        {
            for (int i = 0; i < puzzels.Length; i++)
            {
                if (puzzels[i] == false)
                {
                    puzzels[1] = true;
                    break;
                }
            }
        }
    }

}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CodeGenerator : MonoBehaviour
{
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
            Destroy(GameObject.Find("Geeldraad"));
            //GameObject.Find("GeelGoededraad").SetActive(true);
        }
    }
    

}

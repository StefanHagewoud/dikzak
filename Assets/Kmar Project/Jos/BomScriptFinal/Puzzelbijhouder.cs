using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Puzzelbijhouder : MonoBehaviour
{
    public int puzzelCounter;
    public bool[] puzzels;
    public int number = 1597;
    public int kleurCode = 641;

    public void Start()
    {
        Debug.Log(number);
        Debug.Log(kleurCode);
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

        if (puzzelCounter == 4)
        {
            for (int i = 0; i < puzzels.Length; i++)
            {
                if (puzzels[i] == false)
                {
                    puzzels[2] = true;
                    break;
                }
            }
        }

        bool gotAllpuzzels = true;
        for (int i = 0; i < puzzels.Length; i++)
        {
            if (puzzels[i] == false)
            {
                gotAllpuzzels = false;
                break;
            }
        }
        if (gotAllpuzzels == true)
        {
            GameObject.Find("Timer").GetComponent<BombTimer>().enabled = false;
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.UI;

public class Key : MonoBehaviour
{
    [Header("Key Settings")]
    public string keyNumber;
    public Text keyText;

    public int randomColor;
    public string selectedColor;

    [Header("Lock Settings")]
    public Sprite currentImage;
    public string currentSymbol;

    private int correctKeys;

    // Start is called before the first frame update
    public void Awake()
    {
        keyText = GetComponentInChildren<Text>();

    }
     public void ColorToString()
    {
        if (randomColor == 0)
        {
            selectedColor = "Blue";
        }
        if (randomColor == 1)
        {
            selectedColor = "Green";
        }
        if (randomColor == 2)
        {
            selectedColor = "Pink";
        }
        if (randomColor == 3)
        {
            selectedColor = "Yellow";
        }
    }
    public void CheckCorrectKey()
    {
        Debug.Log(int.Parse(keyNumber));
        if(currentImage.name == "CircleLock" && selectedColor == "Blue")
        {
            if(currentSymbol == "@" && Enumerable.Range(1, 250).Contains(int.Parse(keyNumber)))
            {
                GetComponentInParent<KeySystem>().correctKeys++;
            }
            if (currentSymbol == "#" && Enumerable.Range(251, 500).Contains(int.Parse(keyNumber)))
            {
                GetComponentInParent<KeySystem>().correctKeys++;
            }
            if (currentSymbol == "$" && Enumerable.Range(501, 750).Contains(int.Parse(keyNumber)))
            {
                GetComponentInParent<KeySystem>().correctKeys++;
            }
            if (currentSymbol == "%" && Enumerable.Range(751, 1000).Contains(int.Parse(keyNumber)))
            {
                GetComponentInParent<KeySystem>().correctKeys++;
            }
        }
        if (currentImage.name == "HearthLock" && selectedColor == "Green")
        {
            if (currentSymbol == "@" && Enumerable.Range(1, 250).Contains(int.Parse(keyNumber)))
            {
                GetComponentInParent<KeySystem>().correctKeys++;
            }
            if (currentSymbol == "#" && Enumerable.Range(251, 500).Contains(int.Parse(keyNumber)))
            {
                GetComponentInParent<KeySystem>().correctKeys++;
            }
            if (currentSymbol == "$" && Enumerable.Range(501, 750).Contains(int.Parse(keyNumber)))
            {
                GetComponentInParent<KeySystem>().correctKeys++;
            }
            if (currentSymbol == "%" && Enumerable.Range(751, 1000).Contains(int.Parse(keyNumber)))
            {
                GetComponentInParent<KeySystem>().correctKeys++;
            }
        }
        if (currentImage.name == "SquareLock" && selectedColor == "Pink")
        {
            if (currentSymbol == "@" && Enumerable.Range(1, 250).Contains(int.Parse(keyNumber)))
            {
                GetComponentInParent<KeySystem>().correctKeys++;
            }
            if (currentSymbol == "#" && Enumerable.Range(251, 500).Contains(int.Parse(keyNumber)))
            {
                GetComponentInParent<KeySystem>().correctKeys++;
            }
            if (currentSymbol == "$" && Enumerable.Range(501, 750).Contains(int.Parse(keyNumber)))
            {
                GetComponentInParent<KeySystem>().correctKeys++;
            }
            if (currentSymbol == "%" && Enumerable.Range(751, 1000).Contains(int.Parse(keyNumber)))
            {
                GetComponentInParent<KeySystem>().correctKeys++;
            }
        }
        if (currentImage.name == "TriangleLock" && selectedColor == "Yellow")
        {
            if (currentSymbol == "@" && Enumerable.Range(1, 250).Contains(int.Parse(keyNumber)))
            {
                GetComponentInParent<KeySystem>().correctKeys++;
            }
            if (currentSymbol == "#" && Enumerable.Range(251, 500).Contains(int.Parse(keyNumber)))
            {
                GetComponentInParent<KeySystem>().correctKeys++;
            }
            if (currentSymbol == "$" && Enumerable.Range(501, 750).Contains(int.Parse(keyNumber)))
            {
                GetComponentInParent<KeySystem>().correctKeys++;
            }
            if (currentSymbol == "%" && Enumerable.Range(751, 1000).Contains(int.Parse(keyNumber)))
            {
                GetComponentInParent<KeySystem>().correctKeys++;
            }
        }
    }
}

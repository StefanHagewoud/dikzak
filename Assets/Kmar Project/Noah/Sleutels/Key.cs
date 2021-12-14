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
    public bool correctKey;
    public bool isFilled;

    Color32[] colors = new Color32[4];
    private int randomColor;
    public string selectedColor;

    [Header("Lock Settings")]
    public Sprite currentImage;
    public string currentSymbol;

    // Start is called before the first frame update
    public void Start()
    {

        keyText = GetComponentInChildren<Text>();

        keyNumber = Random.Range(0, 999).ToString();
        keyText.text = keyNumber;

        //Get Random Color out of this list
        colors[0] = new Color32(0, 88, 168, 255); //Blue
        colors[1] = new Color32(0, 135, 80, 255); //Green
        colors[2] = new Color32(168, 0, 75, 255); //Pink
        colors[3] = new Color32(168, 141, 0, 255); //Yellow

        //Gives Object Random Color an Number
        Debug.Log("Gettin random color");
        randomColor = Random.Range(0, colors.Length);
        this.gameObject.GetComponent<Image>().color = colors[randomColor];

        //Set Color into String
        ColorToString();

    }
    public void Update()
    {
        if (isFilled == false)
        {
            Debug.Log("gello");
            CheckCorrectKey();
            isFilled = true;
        }
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
                correctKey = true;
            }
            if (currentSymbol == "#" && Enumerable.Range(251, 500).Contains(int.Parse(keyNumber)))
            {
                correctKey = true;
            }
            if (currentSymbol == "$" && Enumerable.Range(501, 750).Contains(int.Parse(keyNumber)))
            {
                correctKey = true;
            }
            if (currentSymbol == "%" && Enumerable.Range(751, 1000).Contains(int.Parse(keyNumber)))
            {
                correctKey = true;
            }
        }
        if (currentImage.name == "HearthLock" && selectedColor == "Green")
        {
            if (currentSymbol == "@" && Enumerable.Range(1, 250).Contains(int.Parse(keyNumber)))
            {
                correctKey = true;
            }
            if (currentSymbol == "#" && Enumerable.Range(251, 500).Contains(int.Parse(keyNumber)))
            {
                correctKey = true;
            }
            if (currentSymbol == "$" && Enumerable.Range(501, 750).Contains(int.Parse(keyNumber)))
            {
                correctKey = true;
            }
            if (currentSymbol == "%" && Enumerable.Range(751, 1000).Contains(int.Parse(keyNumber)))
            {
                correctKey = true;
            }
        }
        if (currentImage.name == "SquareLock" && selectedColor == "Pink")
        {
            if (currentSymbol == "@" && Enumerable.Range(1, 250).Contains(int.Parse(keyNumber)))
            {
                correctKey = true;
            }
            if (currentSymbol == "#" && Enumerable.Range(251, 500).Contains(int.Parse(keyNumber)))
            {
                correctKey = true;
            }
            if (currentSymbol == "$" && Enumerable.Range(501, 750).Contains(int.Parse(keyNumber)))
            {
                correctKey = true;
            }
            if (currentSymbol == "%" && Enumerable.Range(751, 1000).Contains(int.Parse(keyNumber)))
            {
                correctKey = true;
            }
        }
        if (currentImage.name == "TriangleLock" && selectedColor == "Yellow")
        {
            if (currentSymbol == "@" && Enumerable.Range(1, 250).Contains(int.Parse(keyNumber)))
            {
                correctKey = true;
            }
            if (currentSymbol == "#" && Enumerable.Range(251, 500).Contains(int.Parse(keyNumber)))
            {
                correctKey = true;
            }
            if (currentSymbol == "$" && Enumerable.Range(501, 750).Contains(int.Parse(keyNumber)))
            {
                correctKey = true;
            }
            if (currentSymbol == "%" && Enumerable.Range(751, 1000).Contains(int.Parse(keyNumber)))
            {
                correctKey = true;
            }
        }
    }
}

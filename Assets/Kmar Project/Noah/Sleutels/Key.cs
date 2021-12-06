using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Key : MonoBehaviour
{
    public string keyNumber;
    public Text keyText;

    Color32[] colors = new Color32[4];
    private int randomColor;
    public string selectedColor;
    // Start is called before the first frame update
    void Start()
    {
        keyText = GetComponentInChildren<Text>();

        keyNumber = Random.Range(0, 9999).ToString();
        keyText.text = keyNumber;

        /*
        //Set Random Color
        Color randomColor = new Color(
            Random.Range(0f, 1f), //Red
            Random.Range(0f, 1f), //Green
            Random.Range(0f, 1f), //Blue
            1);  //Transparency

        this.gameObject.GetComponent<Image>().color = randomColor;
        */

        //Get Random Color out of this list
        colors[0] = new Color32(0, 88, 168, 255); //Blue
        colors[1] = new Color32(0, 135, 80, 255); //Green
        colors[2] = new Color32(168, 0, 75, 255); //Pink
        colors[3] = new Color32(168, 141, 0, 255); //Yellow

        Debug.Log("Gettin random color");
        randomColor = Random.Range(0, colors.Length);
        this.gameObject.GetComponent<Image>().color = colors[randomColor];

        //Set Color into String
        ColorToString();
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
}

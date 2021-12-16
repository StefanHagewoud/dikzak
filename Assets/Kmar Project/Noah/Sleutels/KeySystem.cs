using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class KeySystem : MonoBehaviour
{
    [Header("Key Settings")]
    public List<GameObject> keys;
    public int correctKeys;

    [Header("Lock Image Settings")]
    public Image lockImg;
    public Sprite currentLockSprite;
    public Sprite[] lockSprites;
    private int randomSprite;

    [Header("Lock Text Settings")]
    public Text lockText;
    public string[] lockTextSym;
    private int randomText;

    [Header("Key Color Settings")]
    Color32[] colors = new Color32[4];

    public void Awake()
    {
        //Finds all keys in scene and puts them in a List
        keys.AddRange(GameObject.FindGameObjectsWithTag("Keys"));
    }
    // Start is called before the first frame update
    void Start()
    {
        //Changes Lock Image
        randomSprite = Random.Range(0, lockSprites.Length);
        lockImg.GetComponent<Image>().sprite = lockSprites[randomSprite];
        currentLockSprite = lockSprites[randomSprite];

        //Gives the Lock An Random Symbol
        randomText = Random.Range(0, lockTextSym.Length);
        lockText.GetComponent<Text>().text = lockTextSym[randomText];

        //Gives all the keys the Locks data
        for (int i = 0; i <= keys.Count - 1; i++)
        {
            keys[i].GetComponent<Key>().currentImage = currentLockSprite;
            keys[i].GetComponent<Key>().currentSymbol = lockText.text;
        }

        //Key Color Settings
        colors[0] = new Color32(0, 88, 168, 255);  //Blue
        colors[1] = new Color32(0, 135, 80, 255);  //Green
        colors[2] = new Color32(168, 0, 75, 255);  //Pink
        colors[3] = new Color32(168, 141, 0, 255); //Yellow

        //Function for Random Key information
        RandomKeyInfo();
    }

    public void RandomKeyInfo()
    {
        Debug.Log(keys.Count);

        //Gives Keys Random Numbers
        for( int i = 0; i <= keys.Count - 1; i++)
        {
            Debug.Log("Random Number");
            int keyNumber = Random.Range(0, 999);
            keys[i].GetComponent<Key>().keyNumber = keyNumber.ToString();
            keys[i].GetComponent<Key>().keyText.text = keyNumber.ToString();
        }

        //Gives Keys Random Color
        for( int i = 0; i <= keys.Count - 1; i++)
        {
            Debug.Log("Random Color");
            int randomColor = Random.Range(0, colors.Length);
            keys[i].GetComponent<Key>().randomColor = randomColor;
            keys[i].GetComponent<Key>().ColorToString();
            keys[i].GetComponent<Image>().color = colors[randomColor];
        }

        //Checks if Keys Are Correct
        for (int i = 0; i <= keys.Count - 1; i++)
        {
            Debug.Log("Check Correct");
            keys[i].GetComponent<Key>().CheckCorrectKey();
        }

        if(correctKeys == 0)
        {
            RandomKeyInfo();
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class KeysController : MonoBehaviour
{
    [Header("Key Settings")]
    public List<GameObject> keys;

    [Header("Lock Settings")]
    public Text lockText;
    public Image lockImg;
    public Sprite currentLockSprite;
    public Sprite[] lockSprites;
    private int randomSprite;
    public string[] lockTextSym;
    private int randomText;

    public int incorrectKeys;
    private int checkHelper;


    // Start is called before the first frame update
    void Start()
    {
        keys.AddRange(GameObject.FindGameObjectsWithTag("Keys"));

        randomSprite = Random.Range(0, lockSprites.Length);
        lockImg.GetComponent<Image>().sprite = lockSprites[randomSprite];
        currentLockSprite  = lockSprites[randomSprite];

        randomText = Random.Range(0, lockTextSym.Length);
        lockText.GetComponent<Text>().text = lockTextSym[randomText];

        for(int i = 0; 1<= keys.Count; i++)
        {
            keys[i].GetComponent<Key>().currentImage = currentLockSprite;
            keys[i].GetComponent<Key>().currentSymbol = lockText.text;
            if(i == keys.Count)
            {
                KeyManagerHelper();
            }
        }
    }
    // Sprite 0 = Circle
    // Sprite 1  = Hearth
    // Sprite 2 = Square
    // Sprite 3 = Triangle

    // Update is called once per frame

    public void KeyManagerHelper()
    {
        incorrectKeys = 0;
        for (int i = 0; i < keys.Count; i++)
        {
            if (keys[i].GetComponent<Key>().correctKey == false)
            {
                incorrectKeys++;
                Debug.Log("Incorrect Keys Plus One");
            }
        }
    }
    void Update()
    {
        if (incorrectKeys >= 8)
        {
            if(incorrectKeys <= 7)
            {
                return;
            }
            else
            {
                for (checkHelper = 0; checkHelper < keys.Count; checkHelper++)
                {
                    keys[checkHelper].GetComponent<Key>().RandomSettings();
                    KeyManagerHelper();
                }
            }
        }
        else
        {
            incorrectKeys = 0;
            return;
        }

    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Key : MonoBehaviour
{
    public string keyNumber;
    public Text keyText;

    // Start is called before the first frame update
    void Start()
    {
        keyText = GetComponentInChildren<Text>();

        keyNumber = Random.Range(0, 9999).ToString();
        keyText.text = keyNumber;
    }

    // Update is called once per frame
    void Update()
    {

    }
}

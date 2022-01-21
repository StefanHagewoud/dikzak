using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class kleurcodegenerator : MonoBehaviour
{
    public int colorCode;
    public int colorCode1;
    // Start is called before the first frame update
    void Start()
    {
        colorCode = Random.Range(1, 7);
        colorCode1 = Random.Range(1, 7);
        Debug.Log("KleurCode: " + colorCode);
        Debug.Log("KleurCode: " + colorCode1);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

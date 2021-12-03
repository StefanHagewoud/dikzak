using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class KeysController : MonoBehaviour
{
    public List<GameObject> keys;
    // Start is called before the first frame update
    void Start()
    {
        keys.AddRange(GameObject.FindGameObjectsWithTag("Keys"));
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

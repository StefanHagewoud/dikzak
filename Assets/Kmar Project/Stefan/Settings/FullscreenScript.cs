using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FullscreenScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ButtonClick()
    {
        if (!Screen.fullScreen)
        {
            Screen.fullScreen = true;
        } else
        {
            Screen.fullScreen = !Screen.fullScreen;
        }
    }
}

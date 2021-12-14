using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneSwitch : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void SceneSwitchFunction(string level)
    {
        StartCoroutine(waitSeconds(0.7f, level));
    }

    public IEnumerator waitSeconds(float seconds, string level)
    {
        yield return new WaitForSecondsRealtime(seconds);
        SceneManager.LoadScene(level);
    }
}

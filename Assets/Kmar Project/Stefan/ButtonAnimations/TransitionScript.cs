using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TransitionScript : MonoBehaviour
{
    // Start is called before the first frame update
    // public AnimationClip clip;
    public AnimationClip clip;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Transition()
    {
        var animation = GetComponent<Animation>();
        animation.clip = clip;
        animation.Play();
    }
}

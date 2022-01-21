using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using System;

public class AnimBehaviour : MonoBehaviour
{

	// Use this for initialization
	void Start()
	{
		Animator anim = gameObject.GetComponent<Animator>();
		anim.Play("cubeanimation", -1, float.NegativeInfinity);
	}

	// Update is called once per frame
	void Update()
	{

	}

	public void ButtonPressed()
    {
		Debug.Log("AnimationButtonPressed");
		Animator anim = gameObject.GetComponent<Animator>();
		// Reverse animation play
		anim.SetFloat("Direction", -1);
		anim.Play("Open", -1, float.NegativeInfinity);
	}
}
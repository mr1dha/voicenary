using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuAnimation : MonoBehaviour {
	Animator anim;
	bool currentValue;
	Swipe swipeInput;
	// Use this for initialization
	void Start () {
		anim = GetComponent<Animator> ();
		swipeInput = GetComponent<Swipe> ();
	}
	
	// Update is called once per frame
	void Update () {
		if (swipeInput.SwipeUp) {
			anim.SetBool ("Play", true);
		} else if (swipeInput.SwipeDown) {
			anim.SetBool ("Play", false);
		}
	}
}

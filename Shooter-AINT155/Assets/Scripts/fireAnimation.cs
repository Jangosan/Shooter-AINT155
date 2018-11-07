using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fireAnimation : MonoBehaviour {

    private Animator firingAnimation;

	// Use this for initialization
	void Start () {
        firingAnimation = GetComponent<Animator>();
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetButton("Fire1"))
        {
            firingAnimation.SetBool("isFiring", true);
        }
        else
        {
            firingAnimation.SetBool("isFiring", false);
        }
	}
}

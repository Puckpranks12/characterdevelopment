using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerControl : MonoBehaviour {

    public Animator anim;

	// Use this for initialization
	void Start () {
		
	}

    private void FixedUpdate()
    {
        if(Input.GetKeyDown(KeyCode.Alpha1))
        {
            anim.SetBool("isIdle", true);
            anim.SetBool("isJump", false);
            anim.SetBool("isRun", false);
            anim.SetBool("isWalk", false);
        }

        if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            anim.SetBool("isIdle", false);
            anim.SetBool("isJump", true);
            anim.SetBool("isRun", false);
            anim.SetBool("isWalk", false);
        }

        if (Input.GetKeyDown(KeyCode.Alpha3))
        {
            anim.SetBool("isIdle", false);
            anim.SetBool("isJump", false);
            anim.SetBool("isRun", true);
            anim.SetBool("isWalk", false);
        }

        if (Input.GetKeyDown(KeyCode.Alpha4))
        {
            anim.SetBool("isIdle", false);
            anim.SetBool("isJump", false);
            anim.SetBool("isRun", false);
            anim.SetBool("isWalk", true);
        }
    }
}

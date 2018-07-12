using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerSlide : MonoBehaviour {

    public Animator anim;
    

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
        if(Input.GetKeyDown(KeyCode.DownArrow))
        {
            anim.SetBool("SlideMotion",true);
        }
        if(Input.GetKeyUp(KeyCode.DownArrow))
        {
            anim.SetBool("SlideMotion", false);
        }
	}
}

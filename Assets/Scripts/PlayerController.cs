using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {

    public float moveSpeed;
    public float jumpForce;
    

    private Rigidbody2D myRigidbody;


    public bool grounded;
    public LayerMask whatIsGround;

    private bool slide = false;

    private Animator myAnimator;

    private BoxCollider2D myBoxCollider;

    

	// Use this for initialization
	void Start () {
        myRigidbody = GetComponent<Rigidbody2D>();

        myAnimator = GetComponent<Animator>();

        myBoxCollider = GetComponent<BoxCollider2D>();

        
	}
	
	// Update is called once per frame
	void Update () {

        grounded = Physics2D.IsTouchingLayers(myBoxCollider, whatIsGround);
        
        myRigidbody.velocity = new Vector2(moveSpeed, myRigidbody.velocity.y);

        myRigidbody.freezeRotation = true;

        if(Input.GetKeyDown(KeyCode.Space) && !slide)
        {
            if (grounded)
            {
                myRigidbody.velocity = new Vector2(myRigidbody.velocity.x, jumpForce);
                
            }
            
        }

        if (Input.GetKeyDown(KeyCode.DownArrow))
        {
           
                myBoxCollider.size = new Vector2(1, (float)0.9);
                myBoxCollider.offset = new Vector2(0, (float)0.5);
            slide = true;
                
        }
        if (Input.GetKeyUp(KeyCode.DownArrow))
        {
           
                myBoxCollider.size = new Vector2(1, 2);
                myBoxCollider.offset = new Vector2(0, 1);
            slide = false;
            
        }



        myAnimator.SetFloat("Speed", myRigidbody.velocity.x);
        myAnimator.SetBool("Grounded", grounded);
      
	}   
}

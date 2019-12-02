using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Collections;

public class PlayerControler : MonoBehaviour
{
    public float speed;                //Floating point variable to store the player's movement speed.
    public bool isGrounded = false;
    private Rigidbody2D rb2d;        //Store a reference to the Rigidbody2D component required to use 2D Physics.
    public Animator animator;
    float horizontalMove = 0f;
    // Use this for initialization
    void Start()
    {
        //Get and store a reference to the Rigidbody2D component so that we can access it.
        rb2d = GetComponent<Rigidbody2D>();
    }

    //FixedUpdate is called at a fixed interval and is independent of frame rate. Put physics code here.
    void FixedUpdate()
    {
        Jump();

        //Store the current horizontal input in the float moveHorizontal.
        //Store the current vertical input in the float moveVertical.
        //Use the two store floats to create a new Vector2 variable movement.
        Vector2 movement = new Vector2(Input.GetAxisRaw("Horizontal"), 0f);
        horizontalMove = Input.GetAxisRaw("Horizontal");
        animator.SetFloat("Speed", Mathf.Abs(horizontalMove));
        //Call the AddForce function of our Rigidbody2D rb2d supplying movement multiplied by speed to move our player.
        rb2d.AddForce(movement * speed);
    }
    void Jump()
    {
        if (Input.GetButtonDown("Jump") && isGrounded == true)
        {
            gameObject.GetComponent<Rigidbody2D>().AddForce(new Vector2(0f, 22f), ForceMode2D.Impulse);
        }
      
    }
}

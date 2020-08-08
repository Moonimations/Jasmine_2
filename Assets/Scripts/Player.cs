using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class Player : MonoBehaviour {
    public float speed = 5f;
 
    public SpriteRenderer mySpriteRenderer;
    Rigidbody2D rb;



    // This function is called just one time by Unity the moment the component loads
    public void Awake()
    {
        // get a reference to the SpriteRenderer component on this gameObject
        mySpriteRenderer = GetComponent<SpriteRenderer>();
        rb = GetComponent<Rigidbody2D>();
    }

    public void Update()
    {

        ControllPlayer1();
     
}

   

        public void ControllPlayer1()
    {
        if (gravity2.Test == true)
        {
            rb.gravityScale = 0.5f;

            if (Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.LeftArrow))
            {
                mySpriteRenderer.flipX = false;
                transform.position += Vector3.left * speed * Time.deltaTime;

            }
            else if (Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.RightArrow))
            {
                // flip the sprite
                mySpriteRenderer.flipX = true;
                transform.position += Vector3.right * speed * Time.deltaTime;
            }
            if (Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.UpArrow) || Input.GetKey(KeyCode.Space))
            {
               
                   rb.AddForce(Vector2.up * 1f, ForceMode2D.Impulse);
             
               

            }



        }

        if (gravity2.Test == false)
        {
            rb.gravityScale = 0f;
            if (Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.LeftArrow))
            {
                mySpriteRenderer.flipX = false;
                transform.position += Vector3.left * speed * Time.deltaTime;

            }
            else if (Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.RightArrow))
            {
                // flip the sprite
                mySpriteRenderer.flipX = true;
                transform.position += Vector3.right * speed * Time.deltaTime;
            }
            if (Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.UpArrow))
            {

                transform.position += Vector3.up * speed * Time.deltaTime;

            }
            if (Input.GetKey(KeyCode.S) || Input.GetKey(KeyCode.DownArrow))
            {

                transform.position += Vector3.down * speed * Time.deltaTime;

            }
        }

    }
}
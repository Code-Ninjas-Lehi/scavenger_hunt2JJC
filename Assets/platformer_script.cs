using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class platformer_script : MonoBehaviour
{
    public bool grounded;
    public Rigidbody2D RB;
    public float JumpPower;
    public float speed = 50;
    // Update is called once per frame
    void Update()
    {
        RB.AddForce(transform.right * speed * Input.GetAxis("Horizontal"));
        if(grounded == true && Input.GetButtonDown("Jump"))
        {
            RB.AddForce(transform.up * JumpPower);
        }

    }
    
    
    void OnCollisionStay2D(Collision2D other)
    {
        if(other.gameObject.CompareTag("platform"))
        {
            grounded = true;
            
        }
    }



        void OnCollisionExit2D(Collision2D other)
        {
            if(other.gameObject.CompareTag("platform"))
            {
                grounded = false;
            }
        }

    void OnTriggerEnter2D(Collider2D other)
    {
        if(other.gameObject.CompareTag("collectable"))
        {
            Destroy(other.gameObject);
        }
    }
}


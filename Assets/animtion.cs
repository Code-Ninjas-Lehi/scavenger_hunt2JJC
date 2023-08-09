using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class animtion : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }


    public bool grounded;
    public Rigidbody2D RB;
    // Update is called once per frame
    void Update()
    {
        
        if(grounded == true && Input.GetButtonDown("Jump"))
        {
            
        }

    }
    
    
    void OnCollisionEnter2D(Collision2D other)
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
    
}

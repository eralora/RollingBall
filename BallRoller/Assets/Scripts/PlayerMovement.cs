using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public Rigidbody rb;
    public SphereCollider sc;
    public float forwardForce = -500f;
    public float sideForce = -10f;
    public bool turnLeft = false;

    // Update is called once per frame
    void FixedUpdate()
    {
        
        rb.AddForce(forwardForce * Time.deltaTime, 0, 0);

        if (Input.GetKey("d"))
        {
            rb.AddForce(0, 0, -sideForce * Time.deltaTime, ForceMode.VelocityChange);
        }
        else if (Input.GetKey("a"))
        {
            rb.AddForce(0, 0, sideForce * Time.deltaTime, ForceMode.VelocityChange);
        }
        else if (Input.GetKey("s"))
        {
            rb.AddForce(-forwardForce * Time.deltaTime, 0, 0);
        }
        else if (rb.position.y < -1f)
        {
            FindObjectOfType<GameManager>().EndGame();
        }
        
        
    }
    
 
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
     // A reference to the Rigidbody component 
    private Rigidbody rb;

    [Tooltip("How fast the ball moves left/right")]
    [Range(0, 10)]
    public float dodgeSpeed = 5;
    
    [Tooltip("How fast the ball moves forwards automatically")]
    [Range(0, 10)]
    public float rollSpeed = 5;

    // Start is called before the first frame update
    void Start()
    {
        // Get access to our Rigidbody component 
        rb = GetComponent<Rigidbody>();
    }

    /// <summary>
    /// FixedUpdate is called at a fixed framerate and is a prime place to put
    /// Anything based on time.
    /// </summary>
    private void FixedUpdate()
    {

        // Check if we're moving to the side 
        // Check if we're moving to the side 
        rb.AddForce(0, 0, rollSpeed);

    }
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.D))
        {
            transform.position = transform.position + new Vector3(1.5f, 0, 0);
        }

        if (Input.GetKeyDown(KeyCode.A))
        {
            transform.position = transform.position + new Vector3(-1.5f, 0, 0);
        }
    }
}
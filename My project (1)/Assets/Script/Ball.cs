using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    // Making Rigid Body
    Rigidbody rb;



    // Start is called before the first frame update (intializing Goes here)
    void Start()
    {
        rb = GetComponent<Rigidbody>(); // Initializing Rigid Body
    }



    // Gamecode /gameplay - called before each frame
    void Update()
    {

    }

    // Phycics - called before each phycics calc
    void FixedUpdate()
    {
        Vector3 direction = new Vector3(0, 0, 1);
        if (Input.GetKeyDown(KeyCode.Space))
        {
            rb.AddForce(direction * 10, ForceMode.Impulse);
        }

    }
}

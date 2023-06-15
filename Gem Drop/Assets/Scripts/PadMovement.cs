using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class PadMovement : MonoBehaviour
{   
    // Variables 
    float timePressed;
    Vector3 rotationVector;



    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {   


        // Right Arrow Key
        if(Input.GetKey(KeyCode.D))
        {
            if (transform.position.x < 9)
            {
                transform.Translate(Vector3.right * Time.deltaTime * 4, Space.World);
            }
            if (timePressed >= -1 && timePressed < 2)
            {
                timePressed -= 2 * Time.deltaTime * 100;
            }
            
        }

        // Left Arrow Key
        else if (Input.GetKey(KeyCode.A))
        {
            if (transform.position.x > -9)
            {
                transform.Translate(Vector3.left * Time.deltaTime * 4, Space.World);
            }
            
            if (timePressed <= 1 && timePressed < 2)
            {
                timePressed += 2 *  Time.deltaTime * 100;
            }
          
        }

        if (timePressed < 0)
        {
            timePressed += Time.deltaTime * 300;
        }
        else if (timePressed > 0)
        {
            timePressed -= Time.deltaTime * 300;
        }

        timePressed = Mathf.Clamp(timePressed, -.2f, .2f);
        rotationVector = new Vector3(0, 0, timePressed);
        transform.Rotate(rotationVector * Time.deltaTime * 100);

        // Fire Missile




        // Move ship Forward
        transform.Translate(Vector3.forward * 2 * Time.deltaTime, Space.World);
    }


}

/* To DO:
 *  Submission Cycle 2:
    *  - Explosion Particle
 *  Submission Cycle 1:
    *  - Destroy Enemy
    *  - Destroy Missile
 */
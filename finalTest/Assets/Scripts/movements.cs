using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using UnityEngine;
public class movements : MonoBehaviour
{

    // Public Vars
    public GameObject floor;
    public GameObject ceiling;



    // Vars
    Rigidbody character;
    float maximumSpeed = 10;
    float acceleration = 0.001F;
    float delataV = 0;
    float flipper = 1;
    void Start()
    {
        
        character = GetComponent<Rigidbody>();
        Physics.gravity *= 2;
        character.position = new Vector3(-100, .5F, 0);
    }
    void Update()
    {
        // Controls
        if (Input.GetKey(KeyCode.A))
        {
            character.AddForce(new Vector3(0, 0, 2.5F * flipper));
        }
        if (Input.GetKey(KeyCode.D))
        {
            character.AddForce(new Vector3(0, 0, -2.5F * flipper));
        }
        if (Input.GetKeyDown(KeyCode.W) && !(character.position.y > .5F && character.position.y < 6.44))
        {
            character.velocity = new Vector3(character.velocity.x, Physics.gravity.y * -0.95F, character.velocity.z);
        }
        if (Input.GetKey(KeyCode.S) && !(character.position.y > .5F && character.position.y < 6.44))
        {
            character.velocity = new Vector3(character.velocity.x, Physics.gravity.y * -0.75F, character.velocity.z);
        }
        // Invert Gravity
        if (Input.GetKeyDown(KeyCode.Space) && !(character.position.y > .5F && character.position.y < 6.44))
        {
            Physics.gravity = new Vector3(0, Physics.gravity.y * -1F, 0);
            flipper *= -1;
        }
        // Limit Velocity
        float speed = Vector3.Magnitude(character.velocity);
        if (speed > maximumSpeed)
        {
            float brakeSpeed = speed - maximumSpeed; // calculate the speed decrease
            Vector3 normalisedVelocity = character.velocity.normalized;
            Vector3 brakeVelocity = normalisedVelocity * brakeSpeed; // make the brake Vector3 value
            character.AddForce(-brakeVelocity); // apply opposing brake force
        }
        // Normal Motion/ Rest
        character.velocity = new Vector3(character.velocity.x + acceleration, character.velocity.y, character.velocity.z);
        if (character.position.y < 0 || character.position.y > 6.95)
        {
            character.position = new Vector3(-100, .5F, 0);
            character.velocity = Vector3.zero;
            character.angularVelocity = Vector3.zero;
            Physics.gravity = new Vector3(0, 1 * Mathf.Abs(Physics.gravity.y), 0);
            maximumSpeed = 10;
            acceleration = 0.001F;
            delataV = 0;
            flipper = 1;
        }

        character.velocity = new Vector3(10 + delataV, character.velocity.y, character.velocity.z);
        delataV += acceleration;
    }
}
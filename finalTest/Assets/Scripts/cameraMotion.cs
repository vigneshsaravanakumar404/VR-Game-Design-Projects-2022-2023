using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cameraMotion : MonoBehaviour
{
    // Start is called before the first frame update
    Rigidbody rb;
    public GameObject character;
    private float spincount = 0, jumpCount = 0, spinspeed = 1F;

    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        transform.position = new Vector3(character.transform.position.x - 7, 3, character.transform.position.z);
        if (Input.GetKeyDown(KeyCode.Space) && !(character.GetComponent<Rigidbody>().position.y > .5F && character.GetComponent<Rigidbody>().position.y < 6.44))
        {
            jumpCount = 1;
        }
        if (character.GetComponent<Rigidbody>().position.y < 0 || character.GetComponent<Rigidbody>().position.y > 6.95)
        {
            jumpCount = 1;
        }
        //Rotating
        if (jumpCount == 1 && spincount < 180.0/spinspeed)
        {
            transform.Rotate(Vector3.back * spinspeed);
            spincount += 1;
        }
        else
        {
            jumpCount = 0;
            spincount = 0;
        }
        
    }
}
// Requirments
    // Better Terrain
    // Randomize Terrain

// Optional
// Better obstacles
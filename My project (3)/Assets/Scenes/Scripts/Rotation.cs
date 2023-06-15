using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using UnityEngine;

public class Rotation : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey(KeyCode.UpArrow))
        {
            transform.RotateAround(new Vector3(1, 0, 0), 0.01f);
            transform.rotation.z.Equals(0);
        }
        if (Input.GetKey(KeyCode.DownArrow))
        {
            transform.RotateAround(new Vector3(-1, 0, 0), 0.01f);
            transform.rotation.z.Equals(0);
        }
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            transform.RotateAround(new Vector3(0, 1, 0), 0.01f);

        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            transform.RotateAround(new Vector3(0, -1, 0), 0.01f);
            transform.rotation.z.Equals(0);
        }

    }
}

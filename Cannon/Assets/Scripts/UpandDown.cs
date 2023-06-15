using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UpandDown : MonoBehaviour
{
    Vector3 offset = new Vector3(2, 0, 2);

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.UpArrow))
        {
            transform.Rotate(-0.1F, 0, 0);
        }
        if (Input.GetKey(KeyCode.DownArrow))
        {
            transform.Rotate(0.1F, 0, 0);
        }
        
    }
}

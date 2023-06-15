using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotation2 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.LeftArrow) &&(transform.rotation.x>0))
        {
            transform.RotateAround(new Vector3(0, 1, 0), 0.01f);
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            transform.RotateAround(new Vector3(0, -1, 0), 0.01f);
        }
    }
}

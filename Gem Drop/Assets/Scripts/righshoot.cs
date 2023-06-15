using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class righshoot : MonoBehaviour
{
    public GameObject missile;
    bool flip;
    // Start is called before the first frame update
    void Start()
    {
        flip = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            if (flip)
            {
                Instantiate(missile, new Vector3(transform.position.x, transform.position.y, transform.position.z), Quaternion.identity);
            }
            flip = !flip;
        }
    }
}

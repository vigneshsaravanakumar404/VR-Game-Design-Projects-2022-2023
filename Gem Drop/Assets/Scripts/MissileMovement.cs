using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MissileMovement : MonoBehaviour
{
    float startTime;

    // Start is called before the first frame update
    void Start()
    {
        startTime = Time.time;

    }

    // Update is called once per frame
    void Update()
    {
        if(Time.time - startTime > 1F)
        {
            transform.Translate(Vector3.forward * 10 * Time.deltaTime, Space.World);
        }

    }
}

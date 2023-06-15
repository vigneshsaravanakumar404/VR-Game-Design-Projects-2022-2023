using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Launch : MonoBehaviour
{
    // Start is called before the first frame update
    public Transform pof;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            GameObject cube = GameObject.CreatePrimitive(PrimitiveType.Sphere);
            cube.transform.position = transform.position + (new Vector3(0, 0, 0));
            Rigidbody no = cube.AddComponent<Rigidbody>();
            no.isKinematic = false;
            no.AddRelativeForce(Vector3.forward * 21,ForceMode.Impulse);







        }
    }
}

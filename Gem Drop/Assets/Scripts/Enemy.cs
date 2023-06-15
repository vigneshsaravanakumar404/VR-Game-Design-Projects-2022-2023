using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public GameObject enemy;
    public GameObject ship;
    GameObject temp;
    Vector3 scale;
    int count;

    // Start is called before the first frame update
    void Start()
    {
        count = 0;
        scale = new Vector3(0.1f, 0.1f, 0.1f);


    }

    // Update is called once per frame
    void Update()
    {
        count++;
        if (count % 240 == 0)
        {
            transform.position = new Vector3(Random.Range(-9, 9), 0, ship.transform.position.z + 10);
            temp = Instantiate(enemy, new Vector3(transform.position.x, transform.position.y, transform.position.z), Quaternion.identity);
            temp.transform.localScale = scale;
            temp.transform.Translate(Vector3.forward * Time.deltaTime * 1900, Space.World);
            
            
            
            
            count = 0;
        }


    }
}

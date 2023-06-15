using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Attack2 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        string x = collision.gameObject.name;

        // Only Allow Collision When Swinging Sword
        if (x.StartsWith("DarkE"))
        {
            HealthManager2.TakeDamage2(1);

        }

    }
}

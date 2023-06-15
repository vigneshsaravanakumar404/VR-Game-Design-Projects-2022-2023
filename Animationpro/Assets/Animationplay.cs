using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Animationplay : MonoBehaviour
{
    // Start is called before the first frame update
    private Animation anim;

    void Start()
    {
        anim = gameObject.GetComponent<Animation>();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            anim.Play("Two");
        }


        if(Input.GetKeyDown(KeyCode.P))
        {
            int x = Random.Range(1,10);
            anim["Three"].time = (float)x;
            anim.Play("Three");
        }
    }
}

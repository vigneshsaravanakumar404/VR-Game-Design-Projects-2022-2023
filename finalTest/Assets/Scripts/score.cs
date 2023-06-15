using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class score : MonoBehaviour
{
    public GameObject txt;
    public GameObject character;
    int Score = 0;
    // Start is called before the first frame update
    void Start()
    {
        txt.GetComponent<UnityEngine.UI.Text>().text = "hello";

    }

    // Update is called once per frame
    void Update()
    {
        if (Score % 100 == 0)
        {
            txt.GetComponent<UnityEngine.UI.Text>().text = "Score: " + Score;
        }
        if (character.GetComponent<Rigidbody>().position.y < 0 || character.GetComponent<Rigidbody>().position.y > 6)
        {
            Score = 0;
        }
        Score++;
        

    }
}

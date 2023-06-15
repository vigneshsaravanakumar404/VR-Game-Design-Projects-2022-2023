using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DarkKnightMovement : MonoBehaviour
{
    float velocity;
    Rigidbody2D rb;
    Animator animator;
    public bool canJump = true;

    bool reset = false;
    System.Timers.Timer timer1 = new System.Timers.Timer(1150);
    int jumpCount = 1;

    void Start()
    {
        velocity = 1F;
        rb = GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>();
    }

    void Update()
    {
        // Attack/Jump
        if (Input.GetKeyDown(KeyCode.Space))
        {
            animator.SetBool("attack", true);
        }
        if (Input.GetKeyUp(KeyCode.Space))
        {
            animator.SetBool("attack", false);
        }
        if (Input.GetKeyDown(KeyCode.W) && canJump)
        {
            rb = GetComponent<Rigidbody2D>();
            rb.AddForce(new Vector2(0, 9.8F), ForceMode2D.Impulse); 
        }

        // Movement
        if (Input.GetKey(KeyCode.A))
        {
            transform.localScale = new Vector3(1, 1, 1);
            transform.Translate(new Vector2(-0.003F * 5F, 0));
            animator.SetBool("walk", true);
        }
        if (Input.GetKey(KeyCode.D))
        {
            transform.localScale = new Vector3(-1, 1, 1);
            transform.Translate(new Vector2(0.003F * 5F, 0));
            animator.SetBool("walk", true);
        }
        if (Input.GetKey(KeyCode.D) && Input.GetKey(KeyCode.A))
        {
            animator.SetBool("walk", false);
        }
        else if (Input.GetKeyUp(KeyCode.A) || Input.GetKeyUp(KeyCode.D))
        {
            animator.SetBool("walk", false);
        }

        if (HealthManager.healthAmount <= 0)
        {
            GetComponent<Animator>().enabled = false;
            foreach (Transform child in getStuff(gameObject.transform))
            {
                Rigidbody2D rb2d = child.GetComponent<Rigidbody2D>();
                BoxCollider2D bc2d = child.GetComponent<BoxCollider2D>();
                if (rb2d == null)
                {
                    rb2d = child.gameObject.AddComponent<Rigidbody2D>();
                    bc2d = child.gameObject.AddComponent<BoxCollider2D>();
                }
                child.parent = null;
                rb2d.velocity = Vector2.zero;
                rb2d.AddForce(new Vector2(Random.Range(-25, 25), Random.Range(-25, 25)), ForceMode2D.Impulse);
            }
        }


    }


    // Allow Jump Conditions
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.name.StartsWith("enemy"))
        {
            canJump = true;
        } 

    }
    private void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.gameObject.name.StartsWith("enemy"))
        {
            canJump = false;
        }
    }

    private List<Transform> getStuff(Transform character)
    {
        List<Transform> ts = new List<Transform>();
        foreach (Transform t in character)
        {
            ts.Add(t);
            if (t.childCount > 0)
            {
                ts.AddRange(getStuff(t));
            }
        }
        return ts;
    }
}

// To Do
// Make Sword Collisions do something 
// Destroy the villain and make it break 
// Health Bar
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Unity.Mathematics;

public class EnemyMovementAlgorithm : MonoBehaviour
{
    public GameObject target;
    Animator animator;
    bool attack = true;

    float x, deltaX;

    public int health;
    
    void Start()
    {
        animator = GetComponent<Animator>();
        
    }

    // Update is called once per frame
    async void Update()
    {
        deltaX = target.transform.position.x - transform.transform.position.x;

        if (math.abs(deltaX) > 0.0F)
        {
            transform.Translate(new Vector2(0.0025F * deltaX / math.abs(deltaX), 0));
            transform.Translate(new Vector2(0.0025F * deltaX / math.abs(deltaX), 0));
            animator.SetBool("walk", true);
        }
        if (deltaX < 0.0F)
        {
            transform.localScale = new Vector3(1, 1, 1);
        }
        if (deltaX > 0.0F)
        {
            transform.localScale = new Vector3(-1, 1, 1);
        }

       
        if (math.abs(deltaX) < 5 && attack)
        {
            animator.SetBool("attack", true);
            attack = false;
            StartCoroutine(DelayCoroutine());

        }

        if (HealthManager2.healthAmount2 <= 0)
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
                rb2d.AddForce(new Vector2(UnityEngine.Random.Range(-25, 25), UnityEngine.Random.Range(-25, 25)), ForceMode2D.Impulse);
            }
        }




    }
    IEnumerator DelayCoroutine()
    {
        
        Debug.Log("DELAY: " + attack);
        yield return new WaitForSeconds(1);
        attack = true;

    }


    private void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.gameObject.name.StartsWith("Dark"))
        {
            
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
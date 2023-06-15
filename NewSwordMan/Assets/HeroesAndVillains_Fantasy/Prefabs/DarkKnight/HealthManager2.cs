using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthManager2 : MonoBehaviour
{
    public static Image HealthBar2;
    public Image Healthbar22;
    public static float healthAmount2 = 100f;

    // Start is called before the first frame update
    void Start()
    {
        HealthBar2 = Healthbar22;
    }

    // Update is called once per frame
    void Update()
    {

    }

    public static void TakeDamage2(float damage)
    {
        healthAmount2 -= damage;
        HealthBar2.fillAmount = healthAmount2 / 100f;
    }
}

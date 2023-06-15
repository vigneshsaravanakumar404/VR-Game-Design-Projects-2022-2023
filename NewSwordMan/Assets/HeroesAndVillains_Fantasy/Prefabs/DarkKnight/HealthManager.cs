using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthManager : MonoBehaviour
{

    public static Image HealthBar;
    public Image Healthbar2;
    public static float healthAmount = 100f;

    // Start is called before the first frame update
    void Start()
    {
        HealthBar = Healthbar2;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public static void TakeDamage(float damage)
    {
        healthAmount -= damage;
        HealthBar.fillAmount = healthAmount / 100f;
    }

    
}

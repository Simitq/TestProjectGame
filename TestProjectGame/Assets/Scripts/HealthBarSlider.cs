using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthBarSlider : MonoBehaviour
{
    public Slider slider;
    public HealthBar playerHealth;
    //public Text healthText;

    private void Start() {
        
        SetMaxHealth(playerHealth.maxHealth);

    }

    private void Update() {
        SetHealth(playerHealth.health);
    }
    public void SetMaxHealth(int health)
    {
        slider.maxValue = health;
        slider.value = health;
        //healthText.text = health.ToString(); 
    }

    public void SetHealth(int health)
    {
        
        slider.value = health;
        //healthText.text = health.ToString();  
    }
}

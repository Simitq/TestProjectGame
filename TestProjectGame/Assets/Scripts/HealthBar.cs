using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthBar : MonoBehaviour
{
    public int health;
    public int maxHealth;
    public GameObject deadText;
    public GameObject dropItem;

    private void Awake() {
        deadText.SetActive(false);
    }
    public void TakeHit(int damage)
    {
        health -= damage;

        if(health <= 0)
        {
            if(gameObject.tag == "Player")
            {
            deadText.SetActive(true);
            }
            if(gameObject.tag ==  "Enemy")
            {
                Instantiate(dropItem, gameObject.transform.position, Quaternion.identity);
            }
            Destroy(gameObject);
            
        }
    }
    public void SetHealth(int bonusHealth)
    {
        health += bonusHealth;

        if(health > maxHealth)
        {
            health = maxHealth;
        }
    }


}

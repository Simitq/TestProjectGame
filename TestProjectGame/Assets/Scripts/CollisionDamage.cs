using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionDamage : MonoBehaviour
{
    public int collisionDamage = 10;
    public string collisionTag;

    private void OnCollisionEnter2D(Collision2D other) 
    {
        if(other.gameObject.tag == collisionTag)
        {
            HealthBar health = other.gameObject.GetComponent<HealthBar>();
            health.TakeHit(collisionDamage);
        }
    }
}

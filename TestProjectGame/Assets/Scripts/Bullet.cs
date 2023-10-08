using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public float speed;
    public float lifeTime;
    public float distance;
    public int damage;
    public LayerMask whatIsSolid;
    
    

    


    private void Update() {
        
        
        RaycastHit2D hit = Physics2D.Raycast(transform.position, transform.right, distance, whatIsSolid);
        if(hit.collider != null)
        {
            if(hit.collider.CompareTag("Enemy"))
            {
                hit.collider.GetComponent<HealthBar>().TakeHit(damage);
            }
            Destroy(gameObject);
        }
        transform.Translate(transform.right * speed * Time.deltaTime);
    }
    

}

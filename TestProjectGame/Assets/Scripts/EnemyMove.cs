using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMove : MonoBehaviour
{
    float speed = 2;
    public Transform target;

    private void Start() {
        target = GameObject.FindGameObjectWithTag("Player").GetComponent<Transform>();
    }

    private void FixedUpdate() {
        if(transform.position.x - target.position.x <= 8 && transform.position.y - target.position.y <= 5 )
        {
            transform.position = Vector2.MoveTowards(transform.position,target.position,speed*Time.deltaTime);
        
        }
    }
}

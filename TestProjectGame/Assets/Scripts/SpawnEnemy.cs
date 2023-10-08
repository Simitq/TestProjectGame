using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnEnemy : MonoBehaviour
{
    public GameObject enemy1;
    public Transform[] spawnPoint;
    private int maxEnemy = 3;
    int sp;

    private void Awake() {
        MetSpawnEnemy();
    }
    void MetSpawnEnemy()
    {
        for(int i = 0; i < maxEnemy; i++)
        {
            sp = Random.Range(0,3);
            Vector3 spawn = new Vector3(spawnPoint[sp].position.x - Random.Range(0f,4f), spawnPoint[sp].position.y + Random.Range(0f,4f), spawnPoint[sp].position.z);
            Instantiate(enemy1, spawn, Quaternion.identity);
        }
    }
}

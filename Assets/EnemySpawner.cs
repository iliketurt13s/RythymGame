using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    public float spawnCooldown;
    public GameObject enemy;

    void Start()
    {
        Invoke("spawn", spawnCooldown);
    }

    void spawn()
    {
        Instantiate(enemy, new Vector3(Random.Range(-7, 7), 7, 0), Quaternion.identity);
        Invoke("spawn", spawnCooldown);
    }
}

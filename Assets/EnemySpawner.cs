using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    public float spawnCooldown;
    public Transform[] spawnPositions;
    public GameObject enemy;

    void Start()
    {
        Invoke("spawn", spawnCooldown);
    }

    void spawn()
    {
        Instantiate(enemy, spawnPositions[Random.Range(0, spawnPositions.Length)].position, Quaternion.identity);
        Invoke("spawn", spawnCooldown);
    }
}

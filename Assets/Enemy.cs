using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public float speed;
    public int startHealth;
    int health;

    Transform player;

    void Start()
    {
        health = startHealth;
        player = GameObject.FindGameObjectWithTag("player").GetComponent<Transform>();
    }

    void Update()
    {
        Vector3 displacement = transform.position - player.position;
        float angle = Mathf.Atan2(displacement.y, displacement.x) * Mathf.Rad2Deg;
        transform.rotation = Quaternion.Euler(0f, 0f, angle + 90f);

        transform.position = Vector3.MoveTowards(transform.position, player.position, speed * Time.deltaTime);
    
        if (health <= 0){
            Destroy(gameObject);
        }
    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "projectile"){
            health--;
            Destroy(collision.gameObject);
        }
    }
}

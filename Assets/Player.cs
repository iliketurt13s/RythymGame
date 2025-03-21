using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public BeatManager bm;

    public float speed;
    public Transform moveTarget;
    public Rigidbody2D myrb;

    public GameObject projectile;

    void Update()
    {
        Vector3 displacement = transform.position - Camera.main.ScreenToWorldPoint(Input.mousePosition);
        float angle = Mathf.Atan2(displacement.y, displacement.x) * Mathf.Rad2Deg;
        transform.rotation = Quaternion.Euler(0f, 0f, angle + 90f);

        /*if (Input.GetMouseButtonDown(0) || Input.GetKeyDown(KeyCode.Q)){
            if (bm.beatAvailable){
                bm.beatAvailable = false;
                move();
            }
        }
        if (Input.GetMouseButtonDown(1) || Input.GetKeyDown(KeyCode.E)){
            if (bm.beatAvailable){
                bm.beatAvailable = false;
                shoot();
            }
        }*/
    }

    public void move(){
        myrb.AddForce((moveTarget.position - transform.position) * speed, ForceMode2D.Impulse);
    }
    public void shoot(){
        Instantiate(projectile, transform.position, transform.rotation);
    }
}

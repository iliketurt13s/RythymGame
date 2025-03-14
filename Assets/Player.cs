using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public BeatManager bm;

    public float speed;
    public Transform moveTarget;
    public Rigidbody2D myrb;

    void Update()
    {
        Vector3 displacement = transform.position - Camera.main.ScreenToWorldPoint(Input.mousePosition);
        float angle = Mathf.Atan2(displacement.y, displacement.x) * Mathf.Rad2Deg;
        transform.rotation = Quaternion.Euler(0f, 0f, angle + 90f);

        if (Input.GetMouseButtonDown(0)){
            if (bm.beatAvailable){
                bm.beatAvailable = false;
                move();
            }
        }
    }

    void move(){
        myrb.AddForce((moveTarget.position - transform.position) * speed, ForceMode2D.Impulse);
    }
}

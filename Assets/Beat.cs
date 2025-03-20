using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Beat : MonoBehaviour
{
    public float speed;

    public enum BeatTypes {Move, Shoot};
    public BeatTypes type;

    Player p;

    void Start()
    {
        p = GameObject.FindGameObjectWithTag("player").GetComponent<Player>();
    }

    void Update()
    {
        transform.Translate(new Vector3(-speed, 0, 0) * Time.deltaTime);
    }

    public void sound(){
        //yield return new WaitForSeconds(0.1f);

        if (type == BeatTypes.Move){
            p.move();
        } else if (type == BeatTypes.Shoot){
            p.shoot();
        }

        AudioSource audioSource = GetComponent<AudioSource>();
        audioSource.Play();

        //yield return new WaitForSeconds(3f);

        //Destroy(gameObject);
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BeatManager : MonoBehaviour
{
    //[HideInInspector] public bool beatAvailable;

    public GameObject beat;
    //public float[] spawnCooldowns;
    public float spawnCooldown;
    //int iterations = 0;

    public AudioClip bongo;

    void Start()
    {
        //beatAvailable = false;
        //Invoke("spawnBeat", spawnCooldowns[iterations]);
        spawn();
        //iterations++;
    }

    void spawn(){
        Instantiate(beat, new Vector3(10, -4, 0), Quaternion.identity);
        Invoke("spawnBeat", spawnCooldown);
    }

    /*void spawnBeat(){
        GameObject spawned = Instantiate(beat, new Vector3(10, -4, 0), Quaternion.identity);
        AudioSource audio = spawned.GetComponent<AudioSource>();
        audio.clip = bongo;

        if (iterations >= spawnCooldowns.Length){
            iterations = 0;
        }
        Invoke("spawnBeat", spawnCooldowns[iterations]);
        iterations++;
    }*/

    void OnTriggerEnter2D(Collider2D collision){
        if (collision.tag == "beat"){
            //beatAvailable = true;
            
            Beat b = collision.GetComponent<Beat>();
            b.sound();
        }
    }
    void OnTriggerExit2D(Collider2D collision){
        if (collision.tag == "beat"){
            //beatAvailable = false;
        }
    }
}

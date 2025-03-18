using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BeatManager : MonoBehaviour
{
    [HideInInspector] public bool beatAvailable;

    public GameObject beat;
    public float spawnCooldown; //Make better system later

    public AudioClip bongo;

    void Start()
    {
        beatAvailable = false;
        Invoke("spawnBeat", spawnCooldown);
    }

    void spawnBeat(){
        GameObject spawned = Instantiate(beat, new Vector3(10, -4, 0), Quaternion.identity);
        AudioSource audio = spawned.GetComponent<AudioSource>();
        audio.clip = bongo;

        Invoke("spawnBeat", spawnCooldown);
    }

    void OnTriggerEnter2D(Collider2D collision){
        if (collision.tag == "beat"){
            beatAvailable = true;
            
            AudioSource audioSource = collision.GetComponent<AudioSource>();
            audioSource.Play();
        }
    }
    void OnTriggerExit2D(Collider2D collision){
        if (collision.tag == "beat"){
            beatAvailable = false;
        }
    }
}

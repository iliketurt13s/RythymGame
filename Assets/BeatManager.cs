using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BeatManager : MonoBehaviour
{
    [HideInInspector] public bool beatAvailable;

    public GameObject beat;
    public float spawnCooldown; //Make better system later

    void Start()
    {
        beatAvailable = false;
        Invoke("spawnBeat", spawnCooldown);
    }

    void spawnBeat(){
        Instantiate(beat, new Vector3(10, -4, 0), Quaternion.identity);

        Invoke("spawnBeat", spawnCooldown);
    }

    void OnTriggerEnter2D(Collider2D collision){
        if (collision.tag == "beat"){
            beatAvailable = true;
        }
    }
    void OnTriggerExit2D(Collider2D collision){
        if (collision.tag == "beat"){
            beatAvailable = false;
        }
    }
}

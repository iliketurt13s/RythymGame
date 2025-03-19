using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Beat : MonoBehaviour
{
    public float speed;

    void Start()
    {
        
    }

    void Update()
    {
        transform.Translate(new Vector3(-speed, 0, 0) * Time.deltaTime);
    }

    public IEnumerator sound(){
        yield return new WaitForSeconds(0.1f);

        AudioSource audioSource = GetComponent<AudioSource>();
        audioSource.Play();

        yield return new WaitForSeconds(3f);

        Destroy(gameObject);
    }
}

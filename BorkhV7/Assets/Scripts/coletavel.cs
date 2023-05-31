using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class coletavel : MonoBehaviour
{

    private AudioSource audio;

    void Awake(){
        audio = GetComponent<AudioSource>();
    }

  private void OnTriggerEnter2D(Collider2D col )
    {

        if(col.gameObject.tag == "Player")
        {
            audio.Play();
            Destroy(this.gameObject, 0.2f);
        }

    }
    
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement; 

public class EnemyAtak : MonoBehaviour
{
   public GameManagerScript gameMana;
   public AudioClip audioMorte;
   public AudioSource audioSource;

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter2D(Collision2D collision )
    {
        if(collision.gameObject.tag == "Player")
        {
            audioSource.clip = audioMorte;
            audioSource.Play();
            gameMana.gameOver();

            collision.gameObject.GetComponent<Rigidbody2D>().velocity = Vector2.zero;
            collision.gameObject.GetComponent<BoxCollider2D>().enabled = false;
            collision.gameObject.GetComponent<PlayerMove>().enabled = false;
            Cronometro.parart = true;
            

            
            
        }


    
    }

   
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class alavanca2 : MonoBehaviour
{
    public float interactionDistance = 2f; // distância de interação
    public Animator animator; // animator onde as animações da alavanca está
    private bool estado = true; // estado da alavanca
    
    void Update()
    {
        if (Input.GetButton("VERDE0"))
        {
            AudioSource audio = GetComponent<AudioSource>();
            GameObject playerObject = GameObject.Find("Player"); // encontra o objeto do jogador
            if (playerObject != null && Vector3.Distance(transform.position, playerObject.transform.position) <= interactionDistance)
            {
                if (estado == true)
                {
                animator.SetBool("AlavancaAbrindo", true);
                audio.Play();
                estado = false;
                }

                
            }     
        }
    }
        
}

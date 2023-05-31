using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class porta2 : MonoBehaviour
{

  
public Animator porta; //animator da porta
public Animator alavanca1; //animator da alavanca
public Animator alavanca2; //segundo animator alavanca
public AudioClip audioPorta; // o audio clip a ser tocado quando a porta estiver abrindo
private AudioSource audioSource; // referência ao componente AudioSource
private bool tocar = false;

void Start()
{
    porta = GetComponent<Animator>();
    audioSource = GetComponent<AudioSource>(); // obtém a referência do componente AudioSource na mesma porta
}

void Update()
{
    AnimatorStateInfo stateInfo1 = alavanca1.GetCurrentAnimatorStateInfo(0);
    AnimatorStateInfo stateInfo2 = alavanca2.GetCurrentAnimatorStateInfo(0);

    if (stateInfo1.IsName("Lever") && stateInfo2.IsName("Lever"))
    {
        if (!tocar) // verifica se o audio não foi iniciado ainda
        {
            porta.SetBool("PortaAbrindo", true);
            audioSource.clip = audioPorta;
            audioSource.Play();
            tocar = true;
        }
    }
}
}




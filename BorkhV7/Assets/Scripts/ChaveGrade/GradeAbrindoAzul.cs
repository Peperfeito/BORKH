using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GradeAbrindoAzul : MonoBehaviour
{
    private ChaveScriptAzul chaveScript;
    public float distanciaGrade;
    public GameObject Player2;
    public Animator animator;
    public bool PortaAbrindo = false;
    public bool PodeAbrirGrade = false;

    public Texture2D itemTexture;

    private ItemDisplayAzul itemDisplayAzul;

    void Start()
    {
        animator = GetComponent<Animator>();
        chaveScript = GameObject.FindObjectOfType<ChaveScriptAzul>();
        itemDisplayAzul = GameObject.FindObjectOfType<ItemDisplayAzul>();
    }

    
    void Update()
    {
         if (Vector3.Distance(transform.position, Player2.transform.position) <= distanciaGrade)
         {
            PodeAbrirGrade = true;
         }
         else
         {
            PodeAbrirGrade = false;
         }
         if(chaveScript.ChaveAzulDestruida && PodeAbrirGrade == true && ( Input.GetButtonDown("VERDE0")))
         {
        
           PortaAbrindo = true;
           AudioSource audio = GetComponent<AudioSource>();
           animator.SetBool("Abrindo1",true);
           audio.Play(); 
           itemDisplayAzul.HideItem();
         }
    }
}

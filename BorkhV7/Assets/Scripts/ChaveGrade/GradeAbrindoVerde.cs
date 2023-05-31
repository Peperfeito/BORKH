using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GradeAbrindoVerde : MonoBehaviour
{
    [SerializeField] private ChaveScriptVerde chaveScript;
    public float distanciaGrade;
    public GameObject Player2;
    public Animator animator;

    public Texture2D itemTexture;

    private ItemDisplayVerde itemDisplayVerde;

    public bool PortaAbrindo = false;

    private void Start()
    {
        chaveScript = GameObject.FindObjectOfType<ChaveScriptVerde>();
        animator = GetComponent<Animator>();
        itemDisplayVerde = GameObject.FindObjectOfType<ItemDisplayVerde>();
       }

     private void Update()
    {
         if (chaveScript.ChaveVerdeDestruida && Input.GetButtonDown("VERDE0") && Vector3.Distance(transform.position, Player2.transform.position) <= distanciaGrade)
         {
           PortaAbrindo= true;
           AudioSource audio = GetComponent<AudioSource>();
           animator.SetBool("Abrindo",true);
           audio.Play();
           itemDisplayVerde.HideItem();
           
         }
    }

}

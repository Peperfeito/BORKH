using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GradeAbrindoVermelho : MonoBehaviour
{
     [SerializeField] private ChaveVermelha chaveScript;
    public float distanciaGrade;
    public GameObject Player2;
    public Animator animator;

    public Texture2D itemTexture;

    private ItemDisplay itemDisplay;

    public bool PortaAbrindo = false;

    public bool PodeAbrir = false; 

    private void Start()
    {
        chaveScript = GameObject.FindObjectOfType<ChaveVermelha>();
        animator = GetComponent<Animator>();
        itemDisplay = GameObject.FindObjectOfType<ItemDisplay>();
       }

     private void Update()
    {
         if(Vector3.Distance(transform.position, Player2.transform.position) <= distanciaGrade)
         {
             PodeAbrir = true;
         }
         else
         {
            PodeAbrir = false;
         }
         
         if (PodeAbrir == true && chaveScript.ChaveVermelhaDestruida && Input.GetButtonDown("VERDE0"))
         {
           itemDisplay.HideItem();
           PortaAbrindo= true;
           AudioSource audio = GetComponent<AudioSource>();
           animator.SetBool("Abrindo2",true);
           audio.Play();
           }
    }
}

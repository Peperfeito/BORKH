using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChaveVermelha : MonoBehaviour
{
    [SerializeField]
   private bool PodePegarChave =false;
   public bool ChaveVermelhaDestruida= false;
   public float DistanciaInimigo;
   public GameObject chave;
   public GameObject Player2 ;
    public Texture2D itemTexture;

    private bool itemVisible = false;


    public Transform objetoAlvo;  
    public float velocidade = 4.6f; 

   ItemDisplay itemDisplay;


   void Start ()
     {
      itemDisplay = GameObject.FindAnyObjectByType<ItemDisplay>();
     }
   void FixedUpdate ()
   {
     
        Vector3 direcao = objetoAlvo.position - transform.position;
        direcao.Normalize();

        Vector3 posicaoDestino = transform.position + direcao * velocidade * Time.deltaTime;

        transform.position = posicaoDestino;
   }
   
     private void Update()
    
    {
        if (PodePegarChave && Input.GetButtonDown("VERDE0"))
        {
            PegarChave();
            

        }

        if (Vector3.Distance(transform.position, Player2.transform.position) <= DistanciaInimigo)
         {
        PodePegarChave = true;
         }
         else
         {
         PodePegarChave = false;
         }
    
    }
    private void PegarChave ()
    {
        AudioSource audio = GetComponent<AudioSource>();
        audio.Play();
        ChaveVermelhaDestruida= true;
        Destroy(gameObject);
    }
        
    
}

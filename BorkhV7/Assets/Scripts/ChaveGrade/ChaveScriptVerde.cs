using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ChaveScriptVerde : MonoBehaviour
{
   [SerializeField]
   public GameObject Player2;
   public bool PegarChaveEstado =false;
   public bool ChaveVerdeDestruida= false;
   public float distanciaChave;

   public Texture2D itemTexture;

   
   
     private void Update()
    
    {
        if (PegarChaveEstado && Input.GetButtonDown("VERDE0"))
        {
            PegarChave();
            
        }

        if (Vector3.Distance(transform.position, Player2.transform.position) <= distanciaChave)
         {
         PegarChaveEstado = true;
         }
         else
         {
        PegarChaveEstado = false;
         }
    }

    private void PegarChave ()
    {
        ChaveVerdeDestruida= true;
        Destroy(gameObject);
    }
}

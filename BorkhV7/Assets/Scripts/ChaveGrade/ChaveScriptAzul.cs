using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ChaveScriptAzul : MonoBehaviour
{
   public GameObject Player2;
   private bool PegarChaveEstado =false;
   public bool ChaveAzulDestruida= false;
   public float distanciaChave;

   public Texture2D itemTexture;

   ItemDisplayAzul itemDisplayAzul;

   void Start ()

   {
      itemDisplayAzul = GameObject.FindAnyObjectByType<ItemDisplayAzul>();
   }
 
    void Update()
    {
        if (PegarChaveEstado && Input.GetButtonDown("VERDE0"))
        {
            PegarChave();
            itemDisplayAzul.ShowItem();
        
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
        ChaveAzulDestruida= true;
        
        Destroy(gameObject);
    }
    
}

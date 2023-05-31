using UnityEngine;
using UnityEngine.UI;

public class ItemDisplayAzul : MonoBehaviour
{
    public Image itemImage;
    public Transform player;

    private ChaveScriptAzul chaveScript;

    private GradeAbrindoAzul gradeScript;

    
    private void Start ()
    {
        chaveScript = GameObject.FindObjectOfType<ChaveScriptAzul>();
        gradeScript = GameObject.FindObjectOfType<GradeAbrindoAzul>();
    }

    private void Update()
    {
        if (chaveScript.ChaveAzulDestruida)
        {
            ShowItem();
        }

        if(gradeScript.PortaAbrindo ==true)
        {
            HideItem();

        }
    }

    public void ShowItem()
    {
        itemImage.enabled = true;

        
        
    }

    public void HideItem()
    {
        itemImage.enabled = false;
    }
}
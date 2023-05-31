using UnityEngine;
using UnityEngine.UI;

public class ItemDisplayVerde : MonoBehaviour
{
    public Image itemImage;
    public Transform player;

    private ChaveScriptVerde chaveScript;

    private GradeAbrindoVerde gradeScript;

    
    private void Start ()
    {
        chaveScript = GameObject.FindObjectOfType<ChaveScriptVerde>();
        gradeScript = GameObject.FindObjectOfType<GradeAbrindoVerde>();
    }

    private void Update()
    {
        if (chaveScript.ChaveVerdeDestruida)
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
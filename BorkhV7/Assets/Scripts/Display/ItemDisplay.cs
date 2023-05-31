using UnityEngine;
using UnityEngine.UI;

public class ItemDisplay : MonoBehaviour
{
    public Image itemImage;
    public Transform player;

    private ChaveVermelha chaveScript;
    private GradeAbrindoVermelho gradeScript;

    
    private void Start ()
    {
        chaveScript = GameObject.FindObjectOfType<ChaveVermelha>();
        gradeScript = GameObject.FindAnyObjectByType<GradeAbrindoVermelho>();
    }

    private void Update()
    {
        if (chaveScript.ChaveVermelhaDestruida)
        {
            ShowItem();
        }

        if (gradeScript.PortaAbrindo== true)
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


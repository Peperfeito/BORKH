using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DialogueTrigger : MonoBehaviour
{
    public DialogueCont diaCont;
    // Start is called before the first frame update
    void Start()
    {
       DialogurMana.Instance.StartConversation(diaCont);
    }

   
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DialogurMana : MonoBehaviour
{
    public static DialogurMana Instance;
    private DialogueCont currentD;
    private PlayerMove pm;
    private bool endcurrentalk = true;
    public static event System.Action<Dialogue> NewTalker;
    public static event System.Action ResetText;
    public static event System.Action<string> ShowMessage;
    private bool buttonClicked = false;
    public static event System.Action<bool> UIState;

    void Awake()
    {
        Instance = this;
    }

    public void Update()
    {
        
        if (Input.GetButtonDown("VERDE0"))
        {
            ButtonWasClicked();

        }
    }

    public void StartConversation(DialogueCont cont)
    {
        currentD = cont;
        StartCoroutine(StartDialogue());
        UIState?.Invoke(true);
        //FindObjectOfType<PlayerMove>().playerspeed = 0f;
        
        
    }

    private IEnumerator StartDialogue()
    {
        for(int i = 0; i < currentD._dialogues.Length; i++)
        {
            ResetText?.Invoke();
            NewTalker?.Invoke(currentD._dialogues[i]);
            StartCoroutine(ShowDialogue(currentD._dialogues[i].messages));

            yield return new WaitUntil(() => endcurrentalk);
            
        }
        UIState?.Invoke(false);
    }
    
    private IEnumerator ShowDialogue(string[] messages)
    {
        endcurrentalk = false;

        foreach(var message in messages)
        {
            ShowAllMessage(message);
            yield return new WaitUntil(() => buttonClicked);
           
        }
        endcurrentalk = true;
        FindObjectOfType<PlayerMove>().playerspeed = 2.5f;
        
    }

    private void ShowAllMessage(string message)
    {
        ShowMessage?.Invoke(message);
        buttonClicked = false;
        
    }

    public void ButtonWasClicked() =>
        buttonClicked = true;
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class UIManager : MonoBehaviour
{
    public GameObject UIContainer;
    public Image _image;
    public TMP_Text _talkerName;
    public TMP_Text _dialogue;


    void Awake()
    {
        DialogurMana.NewTalker += NewTalker;
        DialogurMana.ShowMessage += ShowText;
        DialogurMana.ResetText += ResetText;
        DialogurMana.UIState += UIContainerState;
        

    }

    void OnDestroy()
    {
        DialogurMana.NewTalker -= NewTalker;
        DialogurMana.ShowMessage -= ShowText;
        DialogurMana.ResetText -= ResetText;
        DialogurMana.UIState -= UIContainerState;
        

    }

    private void NewTalker(Dialogue talkerInfo)
    {
        _image.sprite = talkerInfo._talker._sprite;
        _talkerName.text = talkerInfo._talker.name;
    }

    private void ShowText(string message) =>
        _dialogue.text = message;

    private void ResetText() =>
        _dialogue.text = string.Empty;

    private void UIContainerState(bool state) =>
        UIContainer.SetActive(state);


}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

public class IdeProgram : BaseProgram
{
    [SerializeField] Text WritedCodes,VariablesText;
    [SerializeField] InputField CodeInputField;


    public override void CloseProgram()
    {
        this.gameObject.SetActive(false);
        OnClosed();
    }

    public override void OnClosed()
    {
        ComputerManager.Instance.activeProgram = ComputerManager.Instance.gameObject.GetComponent<BaseProgram>();
    }

    public override void OnOpened()
    {
        ComputerManager.Instance.activeProgram = this;
    }

    public override void OpenProgram()
    {
        OnOpened();
        this.gameObject.SetActive(true);
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Return)) {
            if (ComputerManager.Instance.activeProgram == this)
            {
                SendCodeButton();
            }
        }
    }

    public void SendCodeButton()
    {
        string code = CodeInputField.text.ToLower();
        List<BaseCode> codes = level1Codes.Instance.levelCodes;

        foreach (var i in codes)
        {
            if (code == i.codeString)
            {
                i.codeAction();
                WritedCodes.text += CodeInputField.text.ToLower() + "\n";
                AudioSource.PlayClipAtPoint(Audioclips.Instance.code, ComputerManager.Instance.computerItem.gameObject.transform.position, PlayerPrefs.GetFloat("sfxvolume")* PlayerPrefs.GetFloat("soundvolume"));
                CodeInputField.text = "";
            }
        }





    }

}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class level3Codes : BaseLevel
{

    public static BaseLevel Instance;


    private void Awake()
    {
        Instance = this;
        SetLevel();
    }



    public override void PassNextLevel()
    {
        SceneManager.LoadScene("Level4");
    }

    private void Start()
    {
        SetLevel();
    }

    public override void SetLevel()
    {
        levelCodes.Clear();
        LevelManager.Instance.VariablesText.text = "<color=#00FFCF>public</color> <color=#00FF5B>int</color> temperature,trampolinePower;\n" +
            "<color=#00FFCF>public</color> <color=#F2FF00>static</color> <color=#00FF5B>GameObject</color>  Trampoline;";

        CreateCode createTrampoline = new CreateCode("trampoline", LevelManager.Instance.trampoline);
        levelCodes.Add(createTrampoline);
        DestroyCode destroyTrampoline = new DestroyCode("trampoline", LevelManager.Instance.trampoline);
        levelCodes.Add(destroyTrampoline);
        MinusInt minusTrampolinePower = new MinusInt("trampolinepower", LevelManager.Instance.trampoline.transform.GetChild(0).GetComponent<BaseItemCode>());
        levelCodes.Add(minusTrampolinePower);
        PlusInt plusTrampolinePower = new PlusInt("trampolinepower", LevelManager.Instance.trampoline.transform.GetChild(0).GetComponent<BaseItemCode>());
        levelCodes.Add(plusTrampolinePower);
        PlusInt plusTemperature = new PlusInt("temperature", LevelManager.Instance.water.GetComponent<BaseItemCode>());
        levelCodes.Add(plusTemperature);
        MinusInt minusTemperature = new MinusInt("temperature", LevelManager.Instance.water.GetComponent<BaseItemCode>());
        levelCodes.Add(minusTemperature);

    }
}

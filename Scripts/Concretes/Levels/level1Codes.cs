using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class level1Codes : BaseLevel
{
    public static BaseLevel Instance;


    private void Awake()
    {
        Instance = this;
    }

    private void Start()
    {
        SetLevel();

    }



    public override void PassNextLevel()
    {
        SceneManager.LoadScene("Level2");
    }



    public override void SetLevel()
    {
        levelCodes.Clear();
        LevelManager.Instance.VariablesText.text = "<color=#00FFCF>public</color> <color=#00FF5B>bool</color> bridgeEnabled;\n" +
   "<color=#00FFCF>public</color> <color=#00FF5B>GameObject</color> Box;";


        //LevelManager.Instance.VariablesText.text = "<color=#00FFCF>public</color> <color=#00FF5B>bool</color> bridgeEnabled,doorEnabled;\n" +
        //   "<color=#00FFCF>public</color> <color=#00FF5B>int</color> temperature,trampolinePower;\n" +
        //   "<color=#00FFCF>public</color> <color=#00FF5B>GameObject</color> Box, Ball;\n" +
        //   "<color=#00FFCF>public</color> <color=#F2FF00>static</color> <color=#00FF5B>GameObject</color>  Water, Trampoline;";

        //CreateCode createBall = new CreateCode("ball", LevelManager.Instance.ball, LevelManager.Instance.spawnpoint.transform);
        //levelCodes.Add(createBall);
        //DestroyCode destroyBall = new DestroyCode("ball", LevelManager.Instance.ball);
        //levelCodes.Add(destroyBall);
        CreateCode createBox = new CreateCode("box", LevelManager.Instance.box, LevelManager.Instance.spawnpoint.transform);
        levelCodes.Add(createBox);
        DestroyCode destroyBox = new DestroyCode("box", LevelManager.Instance.box);
        levelCodes.Add(destroyBox);
        //CreateCode createTrampoline = new CreateCode("trampoline", LevelManager.Instance.trampoline);
        //levelCodes.Add(createTrampoline);
        //DestroyCode destroyTrampoline = new DestroyCode("trampoline", LevelManager.Instance.trampoline);
        //levelCodes.Add(destroyTrampoline);
        //MinusInt minusTrampolinePower = new MinusInt("trampolinepower", LevelManager.Instance.trampoline.transform.GetChild(0).GetComponent<BaseItemCode>());
        //levelCodes.Add(minusTrampolinePower);
        //PlusInt plusTrampolinePower = new PlusInt("trampolinepower", LevelManager.Instance.trampoline.transform.GetChild(0).GetComponent<BaseItemCode>());
        //levelCodes.Add(plusTrampolinePower);
        //PlusInt plusTemperature = new PlusInt("temperature", LevelManager.Instance.water.GetComponent<BaseItemCode>());
        //levelCodes.Add(plusTemperature);
        //MinusInt minusTemperature = new MinusInt("temperature", LevelManager.Instance.water.GetComponent<BaseItemCode>());
        //levelCodes.Add(minusTemperature);
        //CreateCode createWater = new CreateCode("water", LevelManager.Instance.water);
        //levelCodes.Add(createWater);
        //DestroyCode destroyWater = new DestroyCode("water", LevelManager.Instance.water);
        //levelCodes.Add(destroyWater);
        TrueBool bridgeEnabledTrue = new TrueBool("bridgeenabled", LevelManager.Instance.bridge.GetComponent<BaseItemCode>());
        levelCodes.Add(bridgeEnabledTrue);
        FalseBool bridgeEnabledFalse = new FalseBool("bridgeenabled", LevelManager.Instance.bridge.GetComponent<BaseItemCode>());
        levelCodes.Add(bridgeEnabledFalse);
        //TrueBool doorEnabledTrue = new TrueBool("doorenabled", LevelManager.Instance.door.GetComponent<BaseItemCode>());
        //levelCodes.Add(doorEnabledTrue);
        //FalseBool doorEnabledFalse = new FalseBool("doorenabled", LevelManager.Instance.door.GetComponent<BaseItemCode>());
        //levelCodes.Add(doorEnabledFalse);
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class level1Codes : BaseLevel
{
    [SerializeField] Text VariablesText;
    [SerializeField] GameObject box,trampoline,water,bridge,door,ball;
    public static level1Codes Instance;

    

    private void Awake()
    {
        Instance = this;
    }
    
    public override void PassNextLevel()
    {
        SceneManager.LoadScene("Level"+LevelId);
    }

    private void Start()
    {



        VariablesText.text = "<color=#00FFCF>public</color> <color=#00FF5B>bool</color> bridgeEnabled,doorEnabled;\n" +
            "<color=#00FFCF>public</color> <color=#00FF5B>int</color> temperature,trampolinePower;\n" +
            "<color=#00FFCF>public</color> <color=#00FF5B>GameObject</color> Box, Ball;\n" +
            "<color=#00FFCF>public</color> <color=#F2FF00>static</color> <color=#00FF5B>GameObject</color>  Water, Trampoline;";

        CreateCode createBall = new CreateCode("ball", ball, bigSpawnPoint);
        levelCodes.Add(createBall);
        DestroyCode destroyBall = new DestroyCode("ball", ball);
        levelCodes.Add(destroyBall);
        CreateCode createBox = new CreateCode("box", box, bigSpawnPoint);
        levelCodes.Add(createBox);
        DestroyCode destroyBox = new DestroyCode("box", box);
        levelCodes.Add(destroyBox);
        CreateCode createTrampoline = new CreateCode("trampoline", trampoline);
        levelCodes.Add(createTrampoline);
        DestroyCode destroyTrampoline = new DestroyCode("trampoline", trampoline);
        levelCodes.Add(destroyTrampoline);
        MinusInt minusTrampolinePower = new MinusInt("trampolinepower",trampoline.transform.GetChild(0).GetComponent<BaseItemCode>());
        levelCodes.Add(minusTrampolinePower);
        PlusInt plusTrampolinePower = new PlusInt("trampolinepower", trampoline.transform.GetChild(0).GetComponent<BaseItemCode>());
        levelCodes.Add(plusTrampolinePower);
        PlusInt plusTemperature = new PlusInt("temperature", water.GetComponent<BaseItemCode>());
        levelCodes.Add(plusTemperature);
        MinusInt minusTemperature = new MinusInt("temperature", water.GetComponent<BaseItemCode>());
        levelCodes.Add(minusTemperature);
        CreateCode createWater = new CreateCode("water", water);
        levelCodes.Add(createWater);
        DestroyCode destroyWater = new DestroyCode("water", water);
        levelCodes.Add(destroyWater);
        TrueBool bridgeEnabledTrue = new TrueBool("bridgeenabled", bridge.GetComponent<BaseItemCode>());
        levelCodes.Add(bridgeEnabledTrue);
        FalseBool bridgeEnabledFalse = new FalseBool("bridgeenabled", bridge.GetComponent<BaseItemCode>());
        levelCodes.Add(bridgeEnabledFalse);
        TrueBool doorEnabledTrue = new TrueBool("doorenabled", door.GetComponent<BaseItemCode>());
        levelCodes.Add(doorEnabledTrue);
        FalseBool doorEnabledFalse = new FalseBool("doorenabled", door.GetComponent<BaseItemCode>());
        levelCodes.Add(doorEnabledFalse);


    }




}

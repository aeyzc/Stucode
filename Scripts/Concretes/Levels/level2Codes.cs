using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class level2Codes : BaseLevel
{

    public static BaseLevel Instance;



    private void Awake()
    {
        Instance = this;
        SetLevel();
    }



    public override void PassNextLevel()
    {
        SceneManager.LoadScene("Level3");
    }

    private void Start()
    {
        SetLevel();

    }
    public override void SetLevel()
    {

        levelCodes.Clear();
        LevelManager.Instance.VariablesText.text = "<color=#00FFCF>public</color> <color=#00FF5B>bool</color> doorEnabled;\n" +
      "<color=#00FFCF>public</color> <color=#00FF5B>GameObject</color> Ball;\n";

        CreateCode createBall = new CreateCode("ball", LevelManager.Instance.ball, LevelManager.Instance.spawnpoint.transform);
        levelCodes.Add(createBall);
        DestroyCode destroyBall = new DestroyCode("ball", LevelManager.Instance.ball);
        levelCodes.Add(destroyBall);
        TrueBool doorEnabledTrue = new TrueBool("doorenabled", LevelManager.Instance.door.GetComponent<BaseItemCode>());
        levelCodes.Add(doorEnabledTrue);
        FalseBool doorEnabledFalse = new FalseBool("doorenabled", LevelManager.Instance.door.GetComponent<BaseItemCode>());
        levelCodes.Add(doorEnabledFalse);

    }
}

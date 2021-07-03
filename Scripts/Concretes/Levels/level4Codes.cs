using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class level4Codes : BaseLevel
{

    public static BaseLevel Instance;


    private void Awake()
    {
        Instance = this;
        SetLevel();
    }



    public override void PassNextLevel()
    {
        CursorManager.Instance.pausedGameCursor();
        SceneManager.LoadScene("MainMenu");
    }

    private void Start()
    {
        SetLevel();
    }

    public override void SetLevel()
    {
        levelCodes.Clear();
        LevelManager.Instance.VariablesText.text = "<color=#00FFCF>public</color> <color=#00FF5B>int</color> temperature;\n" +
            "<color=#00FFCF>public</color> <color=#00FF5B>GameObject</color> Box;\n" +
            "<color=#00FFCF>public</color> <color=#F2FF00>static</color> <color=#00FF5B>GameObject</color> Water;";


        CreateCode createBox = new CreateCode("box", LevelManager.Instance.box, LevelManager.Instance.spawnpoint.transform);
        levelCodes.Add(createBox);
        DestroyCode destroyBox = new DestroyCode("box", LevelManager.Instance.box);
        levelCodes.Add(destroyBox);
        CreateCode createWater = new CreateCode("water", LevelManager.Instance.water);
        levelCodes.Add(createWater);
        DestroyCode destroyWater = new DestroyCode("water", LevelManager.Instance.water);
        levelCodes.Add(destroyWater);
        PlusInt plusTemperature = new PlusInt("temperature", LevelManager.Instance.water.GetComponent<BaseItemCode>());
        levelCodes.Add(plusTemperature);
        MinusInt minusTemperature = new MinusInt("temperature", LevelManager.Instance.water.GetComponent<BaseItemCode>());
        levelCodes.Add(minusTemperature);

    }
}

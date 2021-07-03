using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LevelManager : MonoBehaviour
{
    public Text VariablesText;
    public GameObject spawnpoint, box, trampoline, water, bridge, door, ball;
    public static LevelManager Instance;

    private void Awake()
    {
        Instance = this;
    }




}

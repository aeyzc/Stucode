using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class BaseLevel : MonoBehaviour
{
    public int LevelId;
    public Transform bigSpawnPoint;
    public List<BaseCode> levelCodes = new List<BaseCode> { };
    public abstract void PassNextLevel();

}

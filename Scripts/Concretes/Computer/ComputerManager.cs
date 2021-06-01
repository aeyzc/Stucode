using Stucode.Scripts.Concretes.Item;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ComputerManager : MonoBehaviour
{
    public static ComputerManager Instance;
    public BaseProgram activeProgram;
    public ComputerItem computerItem;

    private void Awake()
    {
        Instance = this;
    }



}

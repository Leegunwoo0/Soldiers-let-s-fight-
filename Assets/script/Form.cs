using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tool
{
    public static string GetGameTag(GameTag _value)
    {
        return _value.ToString(); 
    }

    public enum GameTag
    {
        None,
        Player,
        soldier,
        EnemyTower
    }

    }

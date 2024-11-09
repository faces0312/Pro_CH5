using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

[Serializable]
public class GameData
{
    public int stage;
    public int money;
    //추가 능력치 관련
    public float hpAdditional;
    public float attackAdditional;
    public float criticalAdditional;
    public int criticalChanceAdditional;
}

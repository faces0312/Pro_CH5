using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

[Serializable]
public class GameData
{
    public int stage;
    public int money;
    //레벨 관련
    public int touchLV;
    public int hpLV;
    public int attackLV;
    public int criticalLV;
    public int criticalChanceLV;
    //전투 도우미 관련
    public bool subfirend1On;
    public bool subfirend2On;
    public bool subfirend3On;
    public bool subfirend4On;
}

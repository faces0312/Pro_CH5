using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public enum StatType
{
    Player,
    SubFirend,
    Enemy
}

[CreateAssetMenu(fileName = "Stat", menuName = "New Stat")]
public class StatSO : ScriptableObject
{
    public StatType type;

    public float hp;
    public float attack;
    
    public float critical;
    public int criticalChance;

    public float attackSpeed;
}
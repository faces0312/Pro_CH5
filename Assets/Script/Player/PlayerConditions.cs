using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class PlayerConditions : MonoBehaviour
{
    //플레이어 현재 스탯 값
    public StatSO statSO;
    public float hpTmp;
    public float attackTmp;

    private void Start()
    {
        hpTmp = statSO.hp;
        attackTmp = statSO.attack;
    }

    public void UpdateStats()
    {
        statSO.hp = 100 + Data.Instance.gameData.hpLV * 100;
        statSO.attack = 5 + Data.Instance.gameData.attackLV * 10;
        statSO.critical = Data.Instance.gameData.criticalLV * 20;
        statSO.criticalChance = Data.Instance.gameData.criticalChanceLV;
        Data.Instance.SaveGameData();
    }

    public void PlayerDamaged(float value)
    {
        hpTmp -= value;
    }
}

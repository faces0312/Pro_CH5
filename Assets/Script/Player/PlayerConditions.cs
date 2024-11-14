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
    public float criticalTmp;

    private void Start()
    {
        hpTmp = statSO.hp;
        attackTmp = statSO.attack;
        criticalTmp = statSO.critical;
    }

    public void UpdateStats()
    {
        statSO.hp = 100 + Data.Instance.gameData.hpLV * 100;
        statSO.attack = 5 + Data.Instance.gameData.attackLV * 10;
        statSO.critical = 1 + Data.Instance.gameData.criticalLV * 0.2f;
        statSO.criticalChance = Data.Instance.gameData.criticalChanceLV;
        Data.Instance.SaveGameData();
    }

    public void PlayerDamaged(float value)
    {
        hpTmp -= value;

        if (hpTmp <= 0)
            GameManager.Instance.bossManager.GameOver();
    }
}
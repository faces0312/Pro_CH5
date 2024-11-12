using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerConditions : MonoBehaviour
{
    //�÷��̾� ���� ���� ��
    public StatSO statSO;

    public void UpdateStats()
    {
        statSO.hp = 100 + Data.Instance.gameData.hpLV * 100;
        statSO.attack = 5 + Data.Instance.gameData.attackLV * 10;
        statSO.critical = Data.Instance.gameData.criticalLV * 20;
        statSO.criticalChance = Data.Instance.gameData.criticalChanceLV;
        Data.Instance.SaveGameData();
    }
}

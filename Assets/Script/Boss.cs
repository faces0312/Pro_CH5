using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boss : MonoBehaviour
{
    public StatSO statSO;
    float attackSpeed;

    private void Start()
    {
        UpdateStats();
        attackSpeed = statSO.attackSpeed;
    }

    private void Update()
    {
        if (attackSpeed > 0)
        {
            attackSpeed -= Time.deltaTime;
        }
        else
        {
            Debug.Log("АјАн");
            GameManager.Instance.Player.conditions.PlayerDamaged(statSO.attack);
            attackSpeed = statSO.attackSpeed;
        }
    }

    public void UpdateStats()
    {
        statSO.hp = 300 + (Data.Instance.gameData.stage + 1);
        statSO.attack = 10 + (Data.Instance.gameData.stage + 1);
    }
}

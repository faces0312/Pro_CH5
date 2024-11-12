using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public PlayerController controller;
    public PlayerConditions conditions;
    public PlayerSubFirends subFirends;

    private void Awake()
    {
        GameManager.Instance.Player = this;
        controller = GetComponent<PlayerController>();
        conditions = GetComponent<PlayerConditions>();
        subFirends = GetComponent<PlayerSubFirends>();
    }
    private void Start()
    {
        Data.Instance.gameData.money = 1000;
        Data.Instance.gameData.touchLV = 0;
        Data.Instance.gameData.hpLV = 0;
        Data.Instance.gameData.attackLV = 0;
        Data.Instance.gameData.criticalLV = 0;
        Data.Instance.gameData.criticalChanceLV = 0;

        conditions.UpdateStats();
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public PlayerController controller;
    public PlayerConditions conditions;
    public PlayerSubFirends subFirends;
    public ParticleController particle;

    private void Awake()
    {
        Time.timeScale = 1;
        GameManager.Instance.Player = this;
        controller = GetComponent<PlayerController>();
        conditions = GetComponent<PlayerConditions>();
        subFirends = GetComponent<PlayerSubFirends>();
        particle = GetComponent<ParticleController>();
        conditions.UpdateStats();
    }
    private void Start()
    {
        Data.Instance.gameData.money = 1000;
        /*Data.Instance.gameData.stage = 0;
        Data.Instance.gameData.money = 0;
        Data.Instance.gameData.touchLV = 0;
        Data.Instance.gameData.hpLV = 0;
        Data.Instance.gameData.attackLV = 0;
        Data.Instance.gameData.criticalLV = 0;
        Data.Instance.gameData.criticalChanceLV = 0;
        Data.Instance.gameData.subfirend1On = false;
        Data.Instance.gameData.subfirend2On = false;
        Data.Instance.gameData.subfirend3On = false;
        Data.Instance.gameData.subfirend4On = false;*/
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boss : MonoBehaviour
{
    public StatSO statSO;

    private void Start()
    {
        UpdateStats();
    }

    public void UpdateStats()
    {
        statSO.hp = 300 + (Data.Instance.gameData.stage + 1);
        statSO.attack = 10 + (Data.Instance.gameData.stage + 1);
        Data.Instance.SaveGameData();
    }
}

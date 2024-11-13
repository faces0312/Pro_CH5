using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossManager : MonoBehaviour
{
    int randomBoss;
    public GameObject[] boss;
    public Boss nowBoss;

    public BossCanvas bossCanvas;
    public float hpTmp;

    private void Start()
    {
        GameManager.Instance.bossManager = this;
        randomBoss = Random.Range(0, 3);
        Instantiate(boss[randomBoss]);
        nowBoss = boss[randomBoss].GetComponent<Boss>();
        hpTmp = nowBoss.statSO.hp;
    }

    //데미지 받았을 때
    public void BossDamaged(float value)
    {
        hpTmp -= value;
        bossCanvas.hpSlider.value = hpTmp / nowBoss.statSO.hp;
    }
}

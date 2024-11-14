using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using TMPro;

public class BossManager : MonoBehaviour
{
    public GameObject resultPage;
    public TextMeshProUGUI stageTxt;

    int randomBoss;
    public GameObject[] boss;
    public Boss nowBoss;

    //체력바
    public Slider hpSlider;
    public float hpTmp;
    public TextMeshProUGUI hpTmpTxt;
    //시간
    public Slider timeSlider;
    public float time;
    private float timeTmp;

    private void Start()
    {
        stageTxt.text = $"Stage{Data.Instance.gameData.stage}";
        GameManager.Instance.bossManager = this;
        randomBoss = Random.Range(0, 3);
        Instantiate(boss[randomBoss]);
        nowBoss = boss[randomBoss].GetComponent<Boss>();
        hpTmp = nowBoss.statSO.hp;
        hpTmpTxt.text = ((int)hpTmp).ToString();
        time = 60f;
        timeTmp = time;

    }

    private void Update()
    {
        if(timeTmp <= 0)
        {
            GameOver();
        }

        timeTmp -= Time.deltaTime;
        timeSlider.value = timeTmp / time;
    }

    //데미지 받았을 때
    public void BossDamaged(float value)
    {
        hpTmp -= value;
        hpSlider.value = hpTmp / nowBoss.statSO.hp;
        hpTmpTxt.text = ((int)hpTmp).ToString();

        if (hpTmp <= 0)
            GameClear();
    }

    public void GameOver()
    {
        Time.timeScale = 0;
        resultPage.SetActive(true);
    }

    public void GameClear()
    {
        Time.timeScale = 0;
        Data.Instance.gameData.stage++;
        Data.Instance.SaveGameData();
        resultPage.SetActive(true);
    }

    public void GoBackMain()
    {
        SceneManager.LoadScene("MainScene");
    }
}

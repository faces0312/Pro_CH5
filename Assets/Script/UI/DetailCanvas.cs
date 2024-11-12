using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DetailCanvas : MonoBehaviour
{
    public GameObject[] tools;

    public Button TouchEnhanceButton;
    public Button HpEnhanceButton;
    public Button AttackEnhanceButton;
    public Button CriticalEnhanceButton;
    public Button CriticalChanceEnhanceButton;

    public Button SubFirends1;
    public Button SubFirends2;
    public Button SubFirends3;
    public Button SubFirends4;

    private void Start()
    {
        UpdateSFButton();
    }

    private void Update()
    {
        ButtonEnabled();
    }

    void UpdateSFButton()
    {
        if (Data.Instance.gameData.subfirend1On == true)
            SubFirends1.gameObject.SetActive(false);
        if (Data.Instance.gameData.subfirend2On == true)
            SubFirends2.gameObject.SetActive(false);
        if (Data.Instance.gameData.subfirend3On == true)
            SubFirends3.gameObject.SetActive(false);
        if (Data.Instance.gameData.subfirend4On == true)
            SubFirends4.gameObject.SetActive(false);
    }


    private void ButtonEnabled()
    {
        if (Data.Instance.gameData.money < 10)
            HpEnhanceButton.interactable = false;
        else
            HpEnhanceButton.interactable = true;

        if (Data.Instance.gameData.money < 50)
            AttackEnhanceButton.interactable = false;
        else
            AttackEnhanceButton.interactable = true;

        if (Data.Instance.gameData.money < 100)
            CriticalEnhanceButton.interactable = false;
        else
            CriticalEnhanceButton.interactable = true;

        if (Data.Instance.gameData.money < 150)
            CriticalChanceEnhanceButton.interactable = false;
        else
            CriticalChanceEnhanceButton.interactable = true;

        if (Data.Instance.gameData.money < 50 * (Data.Instance.gameData.touchLV + 1))
            TouchEnhanceButton.interactable = false;
        else
            TouchEnhanceButton.interactable = true;


        if (Data.Instance.gameData.money < 100)
            SubFirends1.interactable = false;
        else
            SubFirends1.interactable = true;

        if (Data.Instance.gameData.money < 200)
            SubFirends2.interactable = false;
        else
            SubFirends2.interactable = true;

        if (Data.Instance.gameData.money < 300)
            SubFirends3.interactable = false;
        else
            SubFirends3.interactable = true;

        if (Data.Instance.gameData.money < 400)
            SubFirends4.interactable = false;
        else
            SubFirends4.interactable = true;
    }

    public void OnEnhance()
    {
        tools[0].SetActive(true);
    }

    public void OnFunction()
    {
        tools[1].SetActive(true);
    }

    public void CancleTools()
    {
        for (int i = 0; i < tools.Length; i++)
        {
            tools[i].gameObject.SetActive(false);
        }
        gameObject.SetActive(false);
    }
    public void TouchEnhance()
    {
        //TODO :: µ·¾øÀ¸¸é ¾ÈµÊ
        Data.Instance.gameData.touchLV += 1;
        Data.Instance.gameData.money -= 50 * Data.Instance.gameData.touchLV;
        GameManager.Instance.Player.conditions.UpdateStats();
    }

    public void HpEnhance()
    {
        //TODO :: µ·¾øÀ¸¸é ¾ÈµÊ
        Data.Instance.gameData.hpLV += 1;
        Data.Instance.gameData.money -= 10;
        GameManager.Instance.Player.conditions.UpdateStats();
    }

    public void AttackEnhance()
    {
        Data.Instance.gameData.attackLV += 1;
        Data.Instance.gameData.money -= 50;
        GameManager.Instance.Player.conditions.UpdateStats();
    }

    public void CriticalEnhance()
    {
        Data.Instance.gameData.criticalLV += 1;
        Data.Instance.gameData.money -= 100;
        GameManager.Instance.Player.conditions.UpdateStats();
    }

    public void CriticalChanceEnhance()
    {
        if(GameManager.Instance.Player.conditions.statSO.criticalChance >= 100)
        {
            HpEnhanceButton.enabled = false;
        }
        Data.Instance.gameData.criticalChanceLV += 1;
        Data.Instance.gameData.money -= 150;
        GameManager.Instance.Player.conditions.UpdateStats();
    }

    public void SubFirend1On()
    {
        SubFirends1.gameObject.SetActive(false);
        Data.Instance.gameData.subfirend1On = true;
        GameManager.Instance.Player.subFirends.UpdateSubFirends();
        Data.Instance.SaveGameData();
    }
    public void SubFirend2On()
    {
        SubFirends2.gameObject.SetActive(false);
        Data.Instance.gameData.subfirend2On = true;
        GameManager.Instance.Player.subFirends.UpdateSubFirends();
        Data.Instance.SaveGameData();

    }
    public void SubFirend3On()
    {
        SubFirends3.gameObject.SetActive(false);
        Data.Instance.gameData.subfirend3On = true;
        GameManager.Instance.Player.subFirends.UpdateSubFirends();
        Data.Instance.SaveGameData();

    }
    public void SubFirend4On()
    {
        SubFirends4.gameObject.SetActive(false);
        Data.Instance.gameData.subfirend4On = true;
        GameManager.Instance.Player.subFirends.UpdateSubFirends();
        Data.Instance.SaveGameData();

    }

}

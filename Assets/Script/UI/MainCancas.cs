using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class MainCancas : MonoBehaviour
{
    public TextMeshProUGUI moneyText;
    
    public DetailCanvas detailCanvas;

    private void Update()
    {
        moneyText.text = Data.Instance.gameData.money.ToString();
    }

    public void BattleStart()
    {
        GameManager.Instance.Is_Battle = true;
        SceneManager.LoadScene("GameScene");
    }

    public void OnDetailEnhance()
    {
        detailCanvas.gameObject.SetActive(true);
        detailCanvas.OnEnhance();
    }

    public void OnDetailFunction()
    {
        detailCanvas.gameObject.SetActive(true);
        detailCanvas.OnFunction();
    }
}

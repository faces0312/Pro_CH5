using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerCanvas : MonoBehaviour
{
    public Slider hpSlider;

    private void Update()
    {
        hpSlider.value = GameManager.Instance.Player.conditions.hpTmp 
            / GameManager.Instance.Player.conditions.statSO.hp;
    }

}

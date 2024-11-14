using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class SubFirend : MonoBehaviour
{
    public StatSO statSO;
    float attackSpeed;

    private void Start()
    {
        Passive();
        attackSpeed = statSO.attackSpeed;
    }
    private void Update()
    {
        Attack();
    }

    public abstract void Passive();

    public void Attack()
    {
        if(GameManager.Instance.Is_Battle == true)
        {
            if (attackSpeed > 0)
            {
                attackSpeed -= Time.deltaTime;
            }
            else
            {
                Debug.Log("АјАн");
                GameManager.Instance.bossManager.BossDamaged(statSO.attack);
                attackSpeed = statSO.attackSpeed;
            }
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerStat : MonoBehaviour
{
    /*// �⺻ ���Ȱ� ���� ���ȵ��� �ɷ�ġ�� �����ؼ� ������ ����ϴ� ������Ʈ
    [SerializeField] private CharacterStat baseStats;*/
    // Start is called before the first frame update
    private void Awake()
    {
        //UpdateCharacterStat();
    }

    /*private void UpdateCharacterStat()
    {
        // statModifier�� �ݿ��ϱ� ���� baseStat�� ���� �޾ƿ�
        StatSO attackSO = null;
        if (baseStats.attackSO != null)
        {
            attackSO = Instantiate(baseStats.attackSO);
        }

        CurrentStat = new CharacterStat { attackSO = attackSO };
        // TODO : ������ �⺻ �ɷ�ġ�� ����ǰ� ������, ���� �ɷ�ġ ��ȭ ��ɵ��� �߰��� ����!
        CurrentStat.statsChangeType = baseStats.statsChangeType;
        CurrentStat.maxHealth = baseStats.maxHealth;
        CurrentStat.speed = baseStats.speed;

    }*/
}

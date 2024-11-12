using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;
using System;

public class PlayerStatHandler : MonoBehaviour
{
    // �⺻ ���Ȱ� ���� ���ȵ��� �ɷ�ġ�� �����ؼ� ������ ����ϴ� ������Ʈ
    [SerializeField] private PlayerStat baseStats;
    public PlayerStat CurrentStat { get; private set; } = new PlayerStat();
    public List<PlayerStat> statsModifiers = new List<PlayerStat>();

    private readonly float MinHp = 100f;
    private readonly float MinAttack = 1f;
    private readonly float MinCritical = 0f;
    private readonly int MinCriticalChance = 0;

    private void Awake()
    {
        UpdateCharacterStat();

        // statModifier�� �ݿ��ϱ� ���� baseStat�� ���� �޾ƿ�
        if (baseStats.statSO != null)
        {
            baseStats.statSO = Instantiate(baseStats.statSO);
            CurrentStat.statSO = Instantiate(CurrentStat.statSO);
        }
    }

    private void UpdateCharacterStat()
    {
        ApplayStatModifier(baseStats);

        foreach (PlayerStat stat in statsModifiers.OrderBy(o => o.statsChangeType))
        {
            ApplayStatModifier(stat);
        }
    }

    private void ApplayStatModifier(PlayerStat modifier)
    {
        Func<float, float, float> operation = modifier.statsChangeType switch
        {
            StatsChangeType.Add => (current, change) => current + change,
            StatsChangeType.Multiple => (current, change) => current * change,
            StatsChangeType.Override => (current, change) => change,
        };

        UpdateAttackStats(operation, modifier);
    }

    private void UpdateAttackStats(Func<float, float, float> operation, PlayerStat modifier)
    {
        if (CurrentStat.statSO == null || modifier.statSO == null) return;

        var currentAttack = CurrentStat.statSO;
        var newAttack = modifier.statSO;

        currentAttack.hp = Mathf.Max(operation(currentAttack.hp, newAttack.hp), MinHp);
        currentAttack.attack = Mathf.Max(operation(currentAttack.attack, newAttack.attack), MinAttack);
        currentAttack.critical = Mathf.Max(operation(currentAttack.critical, newAttack.critical), MinCritical);
        currentAttack.criticalChance = Mathf.Max((int)operation(currentAttack.criticalChance, newAttack.criticalChance), MinCriticalChance);

    }

    public void AddStatModifier(PlayerStat modifier)
    {
        statsModifiers.Add(modifier);
        UpdateCharacterStat();
    }
}

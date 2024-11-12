using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public enum StatsChangeType
{
	Add, // 0
	Multiple, // 1
	Override, // 2
}

[Serializable]
public class PlayerStat
{
	public StatsChangeType statsChangeType;
	public StatSO statSO;
}

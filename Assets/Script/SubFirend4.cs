using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SubFirend4 : SubFirend
{
    public override void Passive()
    {
        GameManager.Instance.Player.conditions.criticalTmp *= 2;
    }

}

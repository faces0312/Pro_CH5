using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SubFirend2 : SubFirend
{
    public override void Passive()
    {
        GameManager.Instance.Player.conditions.hpTmp *= 2;
    }

}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SubFirend3 : SubFirend
{
    public override void Passive()
    {
        GameManager.Instance.Player.conditions.attackTmp *= 2;
    }

}

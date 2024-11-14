using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SubFirend1 : SubFirend
{
    public override void Passive()
    {
        StartCoroutine("SubFirend1_Passive");
    }

    IEnumerator SubFirend1_Passive()
    {
        Data.Instance.gameData.money += 10;
        yield return new WaitForSeconds(5f);
        StartCoroutine("SubFirend1_Passive");
    }
}

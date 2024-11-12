using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossManager : MonoBehaviour
{
    public GameObject[] boss;
    int randomBoss;

    private void Start()
    {
        randomBoss = Random.Range(0, 3);
        Instantiate(boss[randomBoss]);
    }
}

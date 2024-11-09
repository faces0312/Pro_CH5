using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetailCanvas : MonoBehaviour
{
    public GameObject[] tools;

    public void OnEnhance()
    {
        tools[0].SetActive(true);
    }

    public void OnFunction()
    {
        tools[1].SetActive(true);
    }

    public void CancleTools()
    {
        for (int i = 0; i < tools.Length; i++)
        {
            tools[i].gameObject.SetActive(false);
        }
        gameObject.SetActive(false);
    }
}

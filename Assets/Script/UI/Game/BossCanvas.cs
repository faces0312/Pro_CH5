using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BossCanvas : MonoBehaviour
{
    //ü�¹�
    public Slider hpSlider;
    //�ð�
    public Slider timeSlider;
    public float time;
    private float timeTmp;

    private void Start()
    {
        time = 60f;
        timeTmp = time;
    }

    private void Update()
    {
        timeTmp -= Time.deltaTime;
        timeSlider.value = timeTmp / time;
    }

}

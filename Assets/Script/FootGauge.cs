﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FootGauge : MonoBehaviour
{
    public GameObject[] Foots;
    int a = 0;
    
    void Update()
    {
        //クリックしたらFootsを表示する
        if (Input.GetMouseButtonDown(0))
        {
            Foots[a].SetActive(true);
            a += 1;
        }

        //Gaugeが10個溜まったらUpdate処理を終わらす
        if (a==10)
        {
            enabled = false;
        }
    }

    //GameOverMessageに値を渡す
    public int Gauge()
    {
        return a;
    }
}

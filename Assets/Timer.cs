using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Timer : MonoBehaviour
{
    [Header("目前時間")] public float currentTime;
    [Header("正在計時")] public bool isTiming;

    [Header("間隔秒數")] public float interval;
    [Header("計時")] public float countTime;

    void Start()
    {
        
    }
    //開始新的計時
    public void StartNewTiming()
    {
        isTiming = true;
        currentTime = 0;
        //currentTime = Time.realtimeSinceStartup;
    }
    public void Pause()
    {
        isTiming =! isTiming;//雙向開關，true轉false，false轉true
    }
    void FixedUpdate()
    {
        CountCurrentTime();
        SlowUpdate();
    }
    void SlowUpdate()
    {
        if (isTiming)
        {
            countTime += Time.fixedDeltaTime;
            if (countTime > interval)
            {
                countTime = 0;
                Debug.Log(currentTime);
            }
        }
    }
    //計算目前時間
    void CountCurrentTime()
    {
        if (isTiming)
        {
            currentTime += Time.fixedDeltaTime;
        }
    }
}

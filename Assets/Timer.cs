using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Timer : MonoBehaviour
{
    [Header("�ثe�ɶ�")] public float currentTime;
    [Header("���b�p��")] public bool isTiming;

    [Header("���j���")] public float interval;
    [Header("�p��")] public float countTime;

    void Start()
    {
        
    }
    //�}�l�s���p��
    public void StartNewTiming()
    {
        isTiming = true;
        currentTime = 0;
        //currentTime = Time.realtimeSinceStartup;
    }
    public void Pause()
    {
        isTiming =! isTiming;//���V�}���Atrue��false�Afalse��true
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
    //�p��ثe�ɶ�
    void CountCurrentTime()
    {
        if (isTiming)
        {
            currentTime += Time.fixedDeltaTime;
        }
    }
}

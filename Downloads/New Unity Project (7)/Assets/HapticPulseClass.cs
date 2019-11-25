using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HapticPulseClass: MonoBehaviour
{
    SteamVR_TrackedObject Hand;
    SteamVR_Controller.Device Device;
    bool flag = false;
    void Start()
    {
        Hand = GetComponentInParent<SteamVR_TrackedObject>();
        Device = SteamVR_Controller.Input((int)Hand.index);
       
    }
    public void StartGame()
    {
        flag = true;
        StartCoroutine(HpaticPulse());
    }
    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Diglett")
            flag = true;
        StartCoroutine(HpaticPulse());
    }

    //触发震动的条件
    IEnumerator HpaticPulse()
    {
        while (flag)
        {
            Invoke("StopHapticPulse", 0.1f);
            if (Device==null)
            {
                Hand = GetComponentInParent<SteamVR_TrackedObject>();
                Device = SteamVR_Controller.Input((int)Hand.index);
            }
            else
            {
                Device.TriggerHapticPulse(3000);
            }
           
            //等待帧结束执行，等待所有的摄像机和GUI渲染接受后渲染（在屏幕显示之前）
            yield return new WaitForEndOfFrame();
        }
    }
    void StopHapticPulse()
    {
        flag = false;
    }

}


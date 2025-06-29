using System;
using UnityEngine;

public class Test3Logic : MonoBehaviour
{
    private void OnGUI()
    {
        if (GUI.Button(new Rect(10, 20, 100, 20), "发送命令"))
        {
            StopwatchUtility.PrintTime(() =>
            {
                string t = "hello world".GetType().Name;
                Debug.Log(t);
            },10000);
        }
    }
}
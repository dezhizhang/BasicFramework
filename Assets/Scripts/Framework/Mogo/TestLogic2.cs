using System;
using UnityEngine;

public class TestLogic2 : MonoBehaviour
{
    private Player _player;
    private void Awake()
    {
        _player = new Player();
       
        // MonoManager.Instance.StopAllCoroutines();
    }


    private void OnGUI()
    {
        if (GUI.Button(new Rect(10, 20, 100, 50), "开启协程"))
        {
            _player.PrintUpdate();
        }

        if (GUI.Button(new(10, 100, 100, 50), "停止协程"))
        {
            _player.StopPrintUpdate();
        }

        if (GUI.Button(new Rect(10, 160, 100, 50), "关闭所有"))
        {
            _player.StopAllPrintUpdate();
        }
        
    }
}
using UnityEngine;
using System.Collections;


public class Player
{
    public void Show()
    {
        MonoManager.Instance.StartCoroutine(MyCoroutine());
    }

    IEnumerator MyCoroutine()
    {
        while (true)
        {
            Debug.Log("协程执行中...");
            yield return null;
        }
    }
}
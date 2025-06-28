using UnityEngine;
using System.Collections;


public class Player
{
    public void Show()
    {
        GameObject go = GameObject.Find("MonoController");
        go.AddComponent<MonController>().StartCoroutine(MyCoroutine());
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
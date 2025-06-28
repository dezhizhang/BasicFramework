using UnityEngine;
using System.Collections;


public class Player
{
    private Coroutine _coroutine;

    public void Show()
    {
        _coroutine = MonoManager.Instance.StartCoroutine(MyCoroutine());
    }

    public void Hide()
    {
        Debug.Log("_coroutine" + _coroutine);
        MonoManager.Instance.StopCoroutine(_coroutine);
    }

    public void HideAll()
    {
        MonoManager.Instance.StopAllCoroutines();
    }

    public void PrintUpdate()
    {
        MonoManager.Instance.AddUpdateListener(DebugUpdate);
    }


    private void DebugUpdate()
    {
        Debug.Log("DebugUpdate");
    }


    public void StopPrintUpdate()
    {
        MonoManager.Instance.RemoveUpdateListener(DebugUpdate);
    }

    public void StopAllPrintUpdate()
    {
        MonoManager.Instance.RemoveAllListeners();
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
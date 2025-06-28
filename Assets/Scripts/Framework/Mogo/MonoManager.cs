using UnityEngine;
using System.Collections;
using UnityEngine.Events;

/// <summary>
/// mono管理器
/// </summary>
public class MonoManager : SingletonPatternBase<MonoManager>
{
    private MonoController _monoController;

    public MonoController MonoController
    {
        get
        {
            if (_monoController == null)
            {
                // 相当于MonoController
                GameObject go = new GameObject(typeof(MonoController).Name);
                // 组件添加到实例对像中
                _monoController = go.AddComponent<MonoController>();
            }

            return _monoController;
        }
    }

    /// <summary>
    ///  让外部开鹿协程
    /// </summary>
    /// <param name="routine"></param>
    /// <returns></returns>
    public Coroutine StartCoroutine(IEnumerator routine)
    {
        return MonoController.StartCoroutine(routine);
    }

    /// <summary>
    /// 停止协程
    /// </summary>
    /// <param name="routine"></param>
    public void StopCoroutine(IEnumerator routine)
    {
        MonoController.StopCoroutine(routine);
    }

    public void StopCoroutine(Coroutine routine)
    {
        MonoController.StopCoroutine(routine);
    }


    /// <summary>
    /// 停止所有协程方法
    /// </summary>
    public void StopAllCoroutines()
    {
        MonoController.StopAllCoroutines();
    }

    /// <summary>
    /// 
    /// </summary>
    /// <param name="call"></param>
    public void AddUpdateListener(UnityAction call)
    {
        MonoController.AddUpdateListener(call);
    }

    /// <summary>
    /// 移除监听事件
    /// </summary>
    /// <param name="call"></param>
    public void RemoveUpdateListener(UnityAction call)
    {
        MonoController.RemoveUpdateListener(call);
    }

    /// <summary>
    /// 移除所有听事件
    /// </summary>
    public void RemoveAllListeners()
    {
        MonoController.RemoveAllListeners();
    }
}
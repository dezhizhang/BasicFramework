using UnityEngine;
using UnityEngine.Events;

public class MonoController : MonoBehaviour
{
    // 生命周期方法update中执行的事件
    private event UnityAction updateEvent;

    private event UnityAction fixedUpdateEvent;


    private void Update()
    {
        if (updateEvent != null)
        {
            updateEvent?.Invoke();
        }
    }


    void FixedUpdate()
    {
        if (fixedUpdateEvent != null)
        {
            fixedUpdateEvent?.Invoke();
        }
    }

    /// <summary>
    /// 添加监听事件
    /// </summary>
    /// <param name="call"></param>
    public void AddUpdateListener(UnityAction call)
    {
        updateEvent += call;
    }

    /// <summary>
    /// 移除临听事件
    /// </summary>
    /// <param name="call"></param>
    public void RemoveUpdateListener(UnityAction call)
    {
        updateEvent -= call;
    }

    /// <summary>
    /// 移除所有监听事件
    /// </summary>
    public void RemoveAllListeners()
    {
        updateEvent = null;
    }


    /// <summary>
    /// 添加fixedUpdate
    /// </summary>
    /// <param name="call"></param>
    public void AddFixedUpdateListener(UnityAction call)
    {
        fixedUpdateEvent += call;
    }

    /// <summary>
    /// 移除fixedUpdate
    /// </summary>
    /// <param name="call"></param>
    public void RemoveFixedUpdateListener(UnityAction call)
    {
        fixedUpdateEvent -= call;
    }

    /// <summary>
    /// 移除所有事件
    /// </summary>
    public void RemoveFixUpdateAllListeners()
    {
        fixedUpdateEvent = null;
    }
}
using UnityEngine;
using UnityEngine.Events;

public class MonoController : MonoBehaviour
{
    // 生命周期方法update中执行的事件
    private event UnityAction updateEvent;

    // 生命周期方法fixedUpdate执行事件
    private event UnityAction fixedUpdateEvent;

    // 生命周期方法LateUpdate方法
    private event UnityAction lateUpdateEvent;

    private void Update()
    {
        if (updateEvent != null)
        {
            updateEvent?.Invoke();
        }
    }


    private void FixedUpdate()
    {
        if (fixedUpdateEvent != null)
        {
            fixedUpdateEvent?.Invoke();
        }
    }

    private void LateUpdate()
    {
        if (lateUpdateEvent != null)
        {
            lateUpdateEvent?.Invoke();
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

    public void AddLateUpdateListener(UnityAction call)
    {
        lateUpdateEvent += call;
    }

    public void RemoveLateUpdateListener(UnityAction call)
    {
        lateUpdateEvent -= call;
    }

    public void RemoveLateUpdateAllListeners()
    {
        lateUpdateEvent = null;
    }
}
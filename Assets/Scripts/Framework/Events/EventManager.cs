using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

/// <summary>
/// 事件管理中心
/// </summary>
public class EventManager : SingletonPatternBase<EventManager>
{
    // 键表示命令的名称,值表示命令执行的逻辑
    Dictionary<string, UnityAction> events = new Dictionary<string, UnityAction>();


    /// <summary>
    /// 添加监听事件
    /// </summary>
    /// <param name="command"></param>
    /// <param name="listener"></param>
    public void AddEventListener(object command, UnityAction listener)
    {
        string eventName = command.GetType().Name;
        if (!events.ContainsKey(eventName))
        {
            events.Add(eventName, listener);
            return;
        }

        events[eventName] += listener;
    }

    /// <summary>
    /// 
    /// </summary>
    /// <param name="eventName"></param>
    public void DispatchEvent(string eventName)
    {
        if (events.ContainsKey(eventName))
        {
            events[eventName]?.Invoke();
        }
    }

    /// <summary>
    /// 移除事件
    /// </summary>
    /// <param name="eventName"></param>
    /// <param name="listener"></param>
    public void RemoveEventListener(string eventName, UnityAction listener)
    {
        if (events.ContainsKey(eventName))
        {
            events[eventName] -= listener;
        }
    }


    /// <summary>
    /// 移除命令中的所有事件
    /// </summary>
    /// <param name="eventName"></param>
    public void RemoveEventListeners(string eventName)
    {
        if (events.ContainsKey(eventName))
        {
            events[eventName] = null;
        }
    }
}
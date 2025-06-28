using UnityEngine;
using UnityEngine.Events;

public class MonoController : MonoBehaviour
{
    private event UnityAction updateEvent;


    private void Update()
    {
        if (updateEvent != null)
        {
            updateEvent?.Invoke();
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
}
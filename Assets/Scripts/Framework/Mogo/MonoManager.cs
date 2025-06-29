using UnityEngine;
using System.Collections;
using UnityEngine.Events;

/// <summary>
/// mono管理器
/// </summary>
public class MonoManager : SingletonPatternBase<MonoManager>
{
    private MonoController _monoExecutor;
    
    
    private MonoController MonoExecutor
    {
        get
        {
            if (_monoExecutor == null)
            {
                // 相当于MonoController
                GameObject go = new GameObject(typeof(MonoController).Name);
                // 组件添加到实例对像中
                _monoExecutor = go.AddComponent<MonoController>();
            }

            return _monoExecutor;
        }
    }



    public class MonoController : MonoBehaviour
    {
        // 生命周期方法update中执行的事件
        private event UnityAction UpdateEvent;

        // 生命周期方法fixedUpdate执行事件
        private event UnityAction FixedUpdateEvent;

        // 生命周期方法LateUpdate方法
        private event UnityAction LateUpdateEvent;

        private void Update()
        {
            if (UpdateEvent != null)
            {
                UpdateEvent?.Invoke();
            }
        }


        private void FixedUpdate()
        {
            if (FixedUpdateEvent != null)
            {
                FixedUpdateEvent?.Invoke();
            }
        }

        private void LateUpdate()
        {
            if (LateUpdateEvent != null)
            {
                LateUpdateEvent?.Invoke();
            }
        }


        /// <summary>
        /// 添加监听事件
        /// </summary>
        /// <param name="call"></param>
        public void AddUpdateListener(UnityAction call)
        {
            UpdateEvent += call;
        }

        /// <summary>
        /// 移除临听事件
        /// </summary>
        /// <param name="call"></param>
        public void RemoveUpdateListener(UnityAction call)
        {
            UpdateEvent -= call;
        }

        /// <summary>
        /// 移除所有监听事件
        /// </summary>
        public void RemoveAllListeners()
        {
            UpdateEvent = null;
        }


        /// <summary>
        /// 添加fixedUpdate
        /// </summary>
        /// <param name="call"></param>
        public void AddFixedUpdateListener(UnityAction call)
        {
            FixedUpdateEvent += call;
        }

        /// <summary>
        /// 移除fixedUpdate
        /// </summary>
        /// <param name="call"></param>
        public void RemoveFixedUpdateListener(UnityAction call)
        {
            FixedUpdateEvent -= call;
        }

        /// <summary>
        /// 移除所有事件
        /// </summary>
        public void RemoveFixUpdateAllListeners()
        {
            FixedUpdateEvent = null;
        }

        public void AddLateUpdateListener(UnityAction call)
        {
            LateUpdateEvent += call;
        }

        public void RemoveLateUpdateListener(UnityAction call)
        {
            LateUpdateEvent -= call;
        }

        public void RemoveLateUpdateAllListeners()
        {
            LateUpdateEvent = null;
        }
    }


    /// <summary>
    ///  让外部开鹿协程
    /// </summary>
    /// <param name="routine"></param>
    /// <returns></returns>
    public Coroutine StartCoroutine(IEnumerator routine)
    {
        return MonoExecutor.StartCoroutine(routine);
    }

    /// <summary>
    /// 停止协程
    /// </summary>
    /// <param name="routine"></param>
    public void StopCoroutine(IEnumerator routine)
    {
        MonoExecutor.StopCoroutine(routine);
    }

    public void StopCoroutine(Coroutine routine)
    {
        MonoExecutor.StopCoroutine(routine);
    }


    /// <summary>
    /// 停止所有协程方法
    /// </summary>
    public void StopAllCoroutines()
    {
        MonoExecutor.StopAllCoroutines();
    }

    /// <summary>
    /// 
    /// </summary>
    /// <param name="call"></param>
    public void AddUpdateListener(UnityAction call)
    {
        MonoExecutor.AddUpdateListener(call);
    }

    /// <summary>
    /// 移除监听事件
    /// </summary>
    /// <param name="call"></param>
    public void RemoveUpdateListener(UnityAction call)
    {
        MonoExecutor.RemoveUpdateListener(call);
    }

    /// <summary>
    /// 移除所有听事件
    /// </summary>
    public void RemoveAllListeners()
    {
        MonoExecutor.RemoveAllListeners();
    }

    /// <summary>
    ///  添加fixUpdateListener
    /// </summary>
    /// <param name="call"></param>
    public void AddFixedUpdateListener(UnityAction call)
    {
        MonoExecutor.AddFixedUpdateListener(call);
    }

    /// <summary>
    /// 移除fixUpdateListener
    /// </summary>
    /// <param name="call"></param>
    public void RemoveFixedUpdateListener(UnityAction call)
    {
        MonoExecutor.RemoveFixedUpdateListener(call);
    }

    /// <summary>
    ///  RemoveFixUpdate移除所有的添加事件
    /// </summary>
    public void RemoveFixUpdateAllListeners()
    {
        MonoExecutor.RemoveFixUpdateAllListeners();
    }
}
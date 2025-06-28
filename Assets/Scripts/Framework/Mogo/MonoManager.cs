using UnityEngine;
using System.Collections;

/// <summary>
/// mono管理器
/// </summary>
public class MonoManager : SingletonPatternBase<MonoManager>
{
    // 构造方法私有化，访止外部进行实例化
    private MonoManager()
    {
    }

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
        return _monoController.StartCoroutine(routine);
    }
}
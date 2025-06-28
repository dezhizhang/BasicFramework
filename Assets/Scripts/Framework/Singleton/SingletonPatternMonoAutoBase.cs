using UnityEngine;

/// <summary>
/// 继承自MonoBehaviour的单例类
/// </summary>
/// <typeparam name="T"></typeparam>
public class SingletonPatternMonoAutoBase<T> : MonoBehaviour where T : SingletonPatternMonoAutoBase<T>
{
    // 构造函数受集护，防止外部私有化
    protected SingletonPatternMonoAutoBase()
    {
    }

    // 提供一个属性给外部访问，这个属性相当于是单例对像
    private static T _instance;

    public static T Instance
    {
        get
        {
            if (_instance == null)
            {
                _instance = FindAnyObjectByType<T>();
                // 如果对像不存在则创建
                if (_instance == null)
                {
                    // 对像不存在则创建添加进去
                    GameObject obj = new GameObject(typeof(T).Name);
                    _instance = obj.AddComponent<T>();
                }
            }

            return _instance;
        }
    }
}
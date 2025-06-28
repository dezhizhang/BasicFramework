using System;
using UnityEngine;


// 泛型必须为这个类本身或者是它的子类
public class SingletonPatternBase<T> where T : SingletonPatternBase<T>
{
    // 构造方法
    protected SingletonPatternBase()
    {
    }

    // 线程锁，当多线程访问时，同一时间仅一个线程访问
    private static object _lock = new object();

    // volatile 多线程进行修改时，保证都是最新值
    private static T _instance;

    public static T Instance
    {
        get
        {
            if (_instance == null)
            {
                lock (_lock)
                {
                    // 使用反射调用无参构造方法创建对像
                    _instance = Activator.CreateInstance(typeof(T)) as T;
                }
            }

            return _instance;
        }
    }
}
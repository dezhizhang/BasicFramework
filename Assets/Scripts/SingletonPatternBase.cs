using System;
using UnityEngine;


// 泛型必须为这个类本身或者是它的子类
public class SingletonPatternBase<T> where T : SingletonPatternBase<T>
{
    // 构造方法
    protected SingletonPatternBase() {}

    private static T _instance;

    public static T Instance
    {
        get
        {
            // 保证对像的唯一性
            if (_instance == null)
            {
                // 使用反射调用无参构造方法创建对像
                _instance = Activator.CreateInstance(typeof(T)) as T;
            }

            return _instance;
        }
    }
}
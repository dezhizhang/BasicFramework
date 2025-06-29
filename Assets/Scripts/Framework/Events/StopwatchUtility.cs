using System;
using System.Diagnostics;
using UnityEngine;
using UnityEngine.Events;


/// <summary>
/// 工具类，用于计算运行一段代码所需的时间
/// </summary>
public class StopwatchUtility
{
    public static TimeSpan GetTime(UnityAction call)
    {
        // 场明计时器
        Stopwatch timer = new Stopwatch();
        // 开启计时器
        timer.Start();

        // 要测试的代码
        call?.Invoke();

        // 停止定时器
        timer.Stop();
        return timer.Elapsed;
    }

    
    /// <summary>
    /// 优化显示时间
    /// </summary>
    /// <param name="call"></param>
    /// <param name="executionNumber"></param>
    public static void PrintTime(UnityAction call, int executionNumber = 1)
    {
        double totalMilliseconds = 0;

        for (int i = 0; i < executionNumber; i++)
        {
            totalMilliseconds += GetTime(call).TotalMilliseconds;
        }

        UnityEngine.Debug.Log($"执行这段代码所需时间{totalMilliseconds}");
    }
}
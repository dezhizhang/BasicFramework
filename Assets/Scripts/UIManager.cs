using UnityEngine;

public class UIManager : SingletonPatternMonoAutoBase<UIManager>
{
    // 构造方法私有化防方外部访问
    private UIManager()
    {
    }

    public void Show()
    {
        Debug.Log("UIManager:Show");
    }
}
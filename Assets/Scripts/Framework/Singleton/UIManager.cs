using UnityEngine;

public class UIManager : SingletonPatternMonoAutoDontBase<UIManager>
{
    // 构造方法私有化防方外部访问
    private UIManager()
    {
    }

    public void Show()
    {
        Debug.Log("UIManager:Show");
    }

    // 子类重写
    protected override void OnDestroy()
    {
        base.OnDestroy();
    }
}
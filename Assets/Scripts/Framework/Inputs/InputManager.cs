using UnityEngine;

public class InputManager:SingletonPatternBase<InputManager>
{
    // 是否启用脚本功能，监听玩家按健输入
    public bool isActive { get; private set; }

    /// <summary>
    /// 是否激活按健监听
    /// </summary>
    /// <param name="active"></param>
    public void SetActive(bool active)
    {
        isActive = active;
    }

    public InputManager()
    {
        MonoManager.Instance.AddFixedUpdateListener(CheckKeys);
    }


    private void CheckKeys()
    {
        if (!isActive) return;
        if (Input.GetKey(KeyCode.W))
        {
            EventManager.Instance.DispatchEvent(E_InputCommand.GetKeyDown.ToString());
        }
    }
}
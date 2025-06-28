using UnityEngine;

public class UIManager : MonoBehaviour
{
    // 构造方法私有化，防止外部new对像
    private UIManager()
    {
    }

    private static UIManager _instance;

    public static UIManager Instance
    {
        get
        {
            if (_instance == null)
            {
                _instance = FindAnyObjectByType<UIManager>();
            }

            return _instance;
        }
    }

    public void Show()
    {
        Debug.Log("test:" + _instance);
    }
}
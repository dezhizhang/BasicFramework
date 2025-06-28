using UnityEngine;

public class UIManager : MonoBehaviour
{
    // 构造方法私有化，防止外部new对像
    private UIManager()
    {
    }

    // 提供对外的实例
    private static UIManager _instance;


    public static UIManager Instance
    {
        get
        {
            if (_instance == null)
            {
                _instance = FindAnyObjectByType<UIManager>();
                if (_instance == null)
                {
                    GameObject go = new GameObject("UIManager");
                    _instance = go.AddComponent<UIManager>();
                    // 切换场景不销毁实例
                    DontDestroyOnLoad(go);
                }
            }

            return _instance;
        }
    }

    public void Show()
    {
        Debug.Log("Show" + _instance);
    }
}
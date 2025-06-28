using UnityEngine;

public class PlayerModel : SingletonPatternBase<PlayerModel>
{

    // 构造方法私有化，防止外部实例化
    private PlayerModel() {}

    public void Show()
    {
        Debug.Log("hello world");
    }
}
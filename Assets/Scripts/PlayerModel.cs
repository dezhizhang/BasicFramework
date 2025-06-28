public class PlayerModel
{
    public int money;
    // 构造方法私有化，防止外部new对像
    private PlayerModel()
    {
    }

    // 提供给外部一个访问，这个属性相当于单例对像
    private static PlayerModel _instance;

    public static PlayerModel Instance
    {
        get
        {
            // 保证对像的唯一性
            if (_instance == null)
            {
                _instance = new PlayerModel();
            }

            return _instance;
        }
    }
}
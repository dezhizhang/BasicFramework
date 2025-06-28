using UnityEngine;

public class TestLogic : MonoBehaviour
{

    private void Update()
    {

        if (Input.GetKeyDown(KeyCode.Q))
        {
            Debug.Log(PlayerModel.Instance.money);   
        }

        
    }
}

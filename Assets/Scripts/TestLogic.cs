using UnityEngine;
using UnityEngine.SceneManagement;

public class TestLogic : MonoBehaviour
{
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Q))
        {
            UIManager.Instance.Show();
        }
    }
}
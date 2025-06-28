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

        if (Input.GetKeyDown(KeyCode.W))
        {
            SceneManager.LoadScene("Scenes/Singleton2");
        }
    }
}
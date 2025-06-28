using UnityEngine;
using UnityEngine.SceneManagement;

public class TestLogic : MonoBehaviour
{

    private void Update()
    {

        if (Input.GetKeyDown(KeyCode.A))
        {
            SceneManager.LoadScene("Scenes/Singleton2");
        }
        
        if (Input.GetKeyDown(KeyCode.Q))
        {
            UIManager.Instance.Show();
        }


    }
}

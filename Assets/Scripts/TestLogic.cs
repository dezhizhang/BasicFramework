using UnityEngine;

public class TestLogic : MonoBehaviour
{

    private void Update()
    {

        if (Input.GetKeyDown(KeyCode.Q))
        {
            UIManager.Instance.Show();
            
            // Debug.Log(UIManager.Instance.Show);   
        }

        
    }
}

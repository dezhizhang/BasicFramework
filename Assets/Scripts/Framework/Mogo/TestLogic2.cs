using UnityEngine;

public class TestLogic2 : MonoBehaviour
{
    

    
    private void OnGUI()
    {
        if (GUI.Button(new Rect(10, 20, 100, 50), "开启协程"))
        {
            Player player = new Player();
            player.PrintUpdate();
        }

        if (GUI.Button(new(10, 100, 100, 50), "停止协程"))
        {
            Player player = new Player();
            player.StopPrintUpdate();
        }

        if (GUI.Button(new Rect(10, 120, 100, 50), "关闭所有"))
        {
            Player player = new Player();
            player.StopAllPrintUpdate();
        }
        
    }
}
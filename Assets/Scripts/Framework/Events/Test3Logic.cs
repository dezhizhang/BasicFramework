using System;
using UnityEngine;

public class Test3Logic : MonoBehaviour
{
    private void OnGUI()
    {
        if (GUI.Button(new Rect(10, 20, 100, 20), "发送命令"))
        {
            EventManager.Instance.DispatchEvent("Write");

            // GameObject go = GameObject.Find("Cube");
            // go.GetComponent<CubeLogic>().Write();
            //
            // GameObject go2 = GameObject.Find("Sphere");
            // go2.GetComponent<SphereLogic>().Code();
            //
            // GameObject go3 = GameObject.Find("Capsule");
            // go3.GetComponent<CapsuleLogic>().Draw();
        }
    }
}
using UnityEngine;

public class CubeLogic : MonoBehaviour
{
    private void Awake()
    {
        EventManager.Instance.AddEventListener("Write", Write);
    }

    public void Write()
    {
        transform.position += Vector3.right;
        Debug.Log("策划在工作");
    }
}
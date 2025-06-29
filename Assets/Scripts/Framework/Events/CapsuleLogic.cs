using UnityEngine;

public class CapsuleLogic : MonoBehaviour
{
    private void Awake()
    {
        EventManager.Instance.AddEventListener("Draw", Draw);
    }

    public void Draw()
    {
        transform.Rotate(Vector3.forward, 5);
    }
}
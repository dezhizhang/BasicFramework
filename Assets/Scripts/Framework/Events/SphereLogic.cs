using UnityEngine;

public class SphereLogic : MonoBehaviour
{
    private void Awake()
    {
        EventManager.Instance.AddEventListener("Code", Code);
    }

    public void Code()
    {
        transform.localScale += new Vector3(1, 0, 0);
        Debug.Log("程序员在工作");
    }
}
using UnityEngine;

public class SphereLogic : MonoBehaviour
{
    public void Code()
    {
        transform.localScale += new Vector3(1, 0, 0);
        Debug.Log("程序员在工作");
    }
}
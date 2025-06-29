using UnityEngine;

public class CubeLogic : MonoBehaviour
{
   public void Write()
   {
      transform.position += Vector3.right;
      Debug.Log("策划在工作");
   }
}

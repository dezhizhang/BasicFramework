using System.Collections;
using Unity.VisualScripting;
using UnityEngine;

public class TestLogic2 : MonoBehaviour
{
    void Awake()
    {
        Player player = new Player();
        player.Show();
    }
}
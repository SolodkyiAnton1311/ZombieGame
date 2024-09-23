using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    public Transform player;
    public Vector3 offset; 

    void FixedUpdate()
    {
        if (player != null)
        {
            transform.position = player.position + offset;
        }
    }
    public void SetPlayer(Transform playerTransform)
    {
        player = playerTransform;
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pushVertical : MonoBehaviour
{

    public Transform conn;
    float playerPosX;
    float playerPosY;

    private void FixedUpdate()
    {
        playerPosX = conn.position.x;
        playerPosY = conn.position.y;
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        conn.position = new Vector3(playerPosX, playerPosY + 5, 0);
    }

}

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class eventSquare : MonoBehaviour
{

    public Transform playerPos;


    public Vector3[] eventLocation = new Vector3[10];
    public string astralKey = "p";
    bool[] eventDone = new bool[10];
    public bool activateAvailable = false;

    private void Update()
    {
        float playerPosx = playerPos.position.x;
        float playerPosy = playerPos.position.y;

        for (int i = 0; i < eventLocation.Length - 1; i++)
        {
            if (!eventDone[i])
            {
                if (playerPosx >= eventLocation[i].x && playerPosx <= eventLocation[i].x + 10 &&
                playerPosy >= eventLocation[i].y && playerPosy <= eventLocation[i].y + 10)
                {
                    playerPos.position = new Vector3(playerPosx, playerPosy - 25, 0);
                    eventDone[i] = true;
                }
            }
        }
       

        if (!activateAvailable)
        {
            if (Input.GetKeyDown(astralKey))
            {
                playerPos.position = new Vector3(playerPosx, 1, 0);
                activateAvailable = true;
            }
                
            
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RiddleOne : MonoBehaviour
{
    public GameObject riddleOne;
    public GameObject riddleTwo;

    private bool riddleOneActive = true;
    private bool playerInRange = false;

    void Update()
    {

        if (riddleOneActive && playerInRange && Input.GetButtonDown("Interact"))
        {
            Destroy(riddleOne);
            riddleTwo.SetActive(true);
            riddleOneActive = false;
        }

    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.name.Equals("Player"))
        {
            playerInRange = true;
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.name.Equals("Player"))
        {
            playerInRange = false;
        }
    }
}

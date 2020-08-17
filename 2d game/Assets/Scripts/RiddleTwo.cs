using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RiddleTwo : MonoBehaviour
{
    public GameObject riddleTwo;
    public GameObject note;

    private bool riddleTwoActive = true;
    private bool playerInRange = false;

    void Update()
    {

        if (riddleTwoActive && playerInRange && Input.GetButtonDown("Interact"))
        {
            Destroy(riddleTwo);
            note.SetActive(true);
            riddleTwoActive = false;
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

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Note : MonoBehaviour
{
    
    public GameObject note;
    public GameObject magicDoor;
    
    private bool noteActive = true;
    private bool playerInRange = false;

    void Update()
    {

        if (noteActive && playerInRange && Input.GetButtonDown("Interact"))
        {
            Destroy(note);
            magicDoor.SetActive(false);
            noteActive = false;
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

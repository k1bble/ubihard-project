using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class astralProjectionEvent : MonoBehaviour
{
    public bool eventRange;
    public UnityEvent interactAction;

    private void Update()
    {
        if (eventRange)
        {
            interactAction.Invoke();
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            eventRange = true;
            Debug.Log("inside");
        }
            
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            eventRange = false;
            Debug.Log("outside");
        }
    }
}

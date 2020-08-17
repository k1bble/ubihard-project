using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerUI : MonoBehaviour
{

    public GameObject UI;

    private bool uiIsActive = false;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (!uiIsActive && Input.GetButtonDown("OpenUI"))
        {
            UI.SetActive(true);
            uiIsActive = true;
            FindObjectOfType<PlayerMovement>().lockMovement = true;
        }
        else if (uiIsActive && Input.GetButtonDown("OpenUI"))
        {
            UI.SetActive(false);
            uiIsActive = false;
            FindObjectOfType<PlayerMovement>().lockMovement = false;
        }
       
    }

}

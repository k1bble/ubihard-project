using System.Collections;
using System.Collections.Generic;
using UnityEditorInternal;
using UnityEngine;

public class connectPresentnPass : MonoBehaviour
{
    public Transform connectToPast;
    public eventSquare getpresent;
    
    
    void FixedUpdate()
    {
       
        transform.position = new Vector3(connectToPast.position.x, -1, 0);
        
            

    }
}

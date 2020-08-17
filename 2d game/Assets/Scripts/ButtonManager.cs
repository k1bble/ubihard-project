using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonManager : MonoBehaviour
{
    public GameObject[] items;
    public void NextItem()
    {
        int itemLength = items.Length;
        int i = 0;

        while (i < itemLength)
        {
            items[i].SetActive(true);
            i++;

            if (i == itemLength)
            {
                i = 0;
            }
        }

    }
}

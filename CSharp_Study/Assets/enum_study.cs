using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enum_study : MonoBehaviour
{
    enum elements
    {
        a = 1,
        b = 3,
        c,
        d = 7,
        e,
        f = 10
    }

    elements e;

    private void Start()
    {

        e = 0;
        for(e = 0; e <= (elements)10; e++)
        {
            Debug.Log(e);
        }
    }
}

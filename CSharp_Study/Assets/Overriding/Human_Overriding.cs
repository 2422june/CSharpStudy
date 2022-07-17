using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Human_Overriding : MonoBehaviour
{

    private string _name;
    public string Name
    {
        get
        {
            return _name;
        }

        set
        {
            _name = value;
        }
    }

    public virtual void Saying(string syntex)
    {
        Debug.Log(syntex);
    }

    public virtual void Shouting(string syntex)
    {
        Debug.Log(syntex);
    }

    public virtual void Howling(string syntex)
    {
        Debug.Log(syntex);
    }

    public virtual void Bowing(string syntex)
    {
        Debug.Log(syntex);
    }


    public Human_Overriding(string name)
    {
        _name = name;
    }
}

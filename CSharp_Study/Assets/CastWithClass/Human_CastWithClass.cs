using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Human_CastWithClass : MonoBehaviour
{

    protected int _age;
    public int Age
    {
        get
        {
            Debug.Log("Get");
            return _age;
        }

        set
        {
            Debug.Log("Set");
            _age = value;
        }
    }

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

    private string _job;
    public string Job
    {
        get
        {
            return _job;
        }

        set
        {
            _job = value;
        }
    }

    public void Saying(string syntex)
    {
        Debug.Log(syntex);
    }


    public Human_CastWithClass(string name, int age, string job)
    {
        _name = name;
        _age = age;
        _job = job;
    }
}

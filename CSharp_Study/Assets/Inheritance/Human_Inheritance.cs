using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Human_Inheritance : MonoBehaviour
{
    protected int _age;
    public int Age //상속이라서 protected도 사용 가능하다
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

    //virtual : 자식개체가 상속을 받았음에도 메소드를 수정할 수 있도록 하는 것
    public void Saying(string syntex)
    {
        Debug.Log(syntex);
    }


    public Human_Inheritance(string name, int age, string job)
    {
        _name = name;
        _age = age;
        _job = job;
    }
}

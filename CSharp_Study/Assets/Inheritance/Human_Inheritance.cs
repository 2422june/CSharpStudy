using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Human_Inheritance : MonoBehaviour
{
    protected int _age;
    public int Age //����̶� protected�� ��� �����ϴ�
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

    //virtual : �ڽİ�ü�� ����� �޾������� �޼ҵ带 ������ �� �ֵ��� �ϴ� ��
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

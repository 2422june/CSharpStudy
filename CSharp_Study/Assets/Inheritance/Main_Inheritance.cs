using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Main_Inheritance : MonoBehaviour//���
{
    June_Inheritance j;

    void Start()
    {

        j = new June_Inheritance("a", 1, null);

        Debug.Log(j.Name);
        Debug.Log($"this age is {j.sayThisAge()}");
        Debug.Log($"base age is {j.sayBaseAge()}");
        j.Saying("Ha! Ha! Ha!");
    }
}

class June_Inheritance : Human_Inheritance//���
{
    int _age;


    public int sayThisAge()
    {
        this._age = 10;
        return this._age;
        //this�� �ڱ��ڽ��� �Ӽ��� �����Ѵ�.
    }
    public int sayBaseAge()
    {
        return base._age;
        //base�� �θ��� �Ӽ��� �����Ѵ�.
    }

    public June_Inheritance(string name, int age, string job) : base(name, age, job)
    {
        /* ������ �޼ҵ��� ��� (�� ����� �����ϸ� �޼ҵ� ������ ��ӵ� �� ����.)
         * 
         * ���� 1. �� ������ �ش��ϴ� �Ķ������ �̸��� ���� ��.
         * ���� 2. �� ������ �ش��ϴ� �Ķ������ �ڷ����� ���� ��.
         * ���� 3. ������ �� ��.
         * ���� 4. ����� ���� baseŰ����� �����ڿ� ������ ��.
         * 
         * ���� ���ǵ��� �����ɽ� �����ڴ�
         * �θ��� �������� ����� ��ӵȴ�.
         * 
         */
    }
}

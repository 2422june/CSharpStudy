using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//�߻�ȭ, ĸ��ȭ
public class Main : MonoBehaviour
{
    Human June;

    void Start()
    {
        June = new Human("June", 18, "Student", 167f, 70f);

        June.Age = June.Age;//Get, Set ������Ƽ �̿�
    }
}

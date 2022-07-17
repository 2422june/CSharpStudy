using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//추상화, 캡슐화
public class Main : MonoBehaviour
{
    Human June;

    void Start()
    {
        June = new Human("June", 18, "Student", 167f, 70f);

        June.Age = June.Age;//Get, Set 프로퍼티 이용
    }
}

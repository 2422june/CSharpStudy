using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Main_Inheritance : MonoBehaviour//상속
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

class June_Inheritance : Human_Inheritance//상속
{
    int _age;


    public int sayThisAge()
    {
        this._age = 10;
        return this._age;
        //this는 자기자신의 속성에 접근한다.
    }
    public int sayBaseAge()
    {
        return base._age;
        //base는 부모의 속성에 접근한다.
    }

    public June_Inheritance(string name, int age, string job) : base(name, age, job)
    {
        /* 생성자 메소드의 상속 (이 기능을 제외하면 메소드 끼리는 상속될 수 없다.)
         * 
         * 조건 1. 각 순서에 해당하는 파라매터의 이름이 같을 것.
         * 조건 2. 각 순서에 해당하는 파라매터의 자료형이 같을 것.
         * 조건 3. 생성자 일 것.
         * 조건 4. 상속을 톻해 base키워드로 생성자에 접근할 것.
         * 
         * 위의 조건들이 성립될시 생성자는
         * 부모의 생성자의 기능이 상속된다.
         * 
         */
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Main_Overriding : MonoBehaviour
{
    June_Overriding j1;
    Human_Overriding h1;

    June_Overriding j2;
    Human_Overriding h2;

    #region 오버라이딩

    //매개변수만 달라도 다른 메소드로 생각한다.
    void Add(int a)
    {
        Debug.Log(a++);
    }

    void Add(float a)
    {
        Debug.Log(a++);
    }
    #endregion

    void Start()
    {
        j1 = new June_Overriding("a1");
        //j2 = new Human_Overriding("a2"); 에러
        h1 = new Human_Overriding("a3");
        h2 = new June_Overriding("a4");


        //둘다 오직 준에게만 영향을 받기에 둘다 효과가 존재한다.

        j1.Saying("It's Inheritance");
        //j1.Shouting("It's Inheritance");
        j1.Howling("It's Inheritance");
        //j1.Bowing("It's Inheritance");


        Debug.Log("====================");

        //둘다 june과는 연관이 없기에 어떤 효과도 없다.

        h1.Saying("It's Inheritance");
        //h1.Shouting("It's Inheritance");
        h1.Howling("It's Inheritance");
        //h1.Bowing("It's Inheritance");

        Debug.Log("====================");

        //재정의 되었기에 효과가 존재한다.
        h2.Saying("It's Inheritance");
        //h2.Shouting("It's Inheritance");

        // june에서 새로운 함수를 만든 것 이기에 효과를 주지 못 한다.
        //솔직히 이건 애매하다. (human에는 없는 메소드는 못 받아 온 건가?)
        h2.Howling("It's Inheritance"); 
        //h2.Bowing("It's Inheritance");

        Debug.Log("====================");
    }
}

class June_Overriding : Human_Overriding//상속
{

    public override void Saying(string syntex)//메소드 재정의
    {
        Debug.Log("It's Override");
    }
    public override void Shouting(string syntex)//메소드 재정의
    {
        Debug.Log("It's Override");
        base.Shouting(syntex);//부모의 메소드 호출
    }

    public new void Howling(string syntex) //매소드 재선언
    {
        Debug.Log("It's New");
    }
    public new void Bowing(string syntex) //매소드 재선언
    {
        Debug.Log("It's New");
        base.Bowing(syntex);
    }

    public June_Overriding(string name) : base(name)
    {

    }
}

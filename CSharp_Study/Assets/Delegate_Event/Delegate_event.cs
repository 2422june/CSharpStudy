using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Delegate_event : MonoBehaviour
{

    //delegate : 메소드를 담는 데이터 타입, 실행도 시켜줌
    delegate void sayHello();
    delegate void sayHello2();
    delegate void sayHello3();

    void Start()
    {
        //대입시 바로 실행
        sayHello hello = new sayHello(SayHello);
        sayHello2 hello2 = SayHello2;

        sayHello2 hello3 = SayHello;
        hello3 += SayHello2;//멀티 캐스트

        hello();
        hello2();//실행이 안되는 이유 : 값이 그냥 메소드이기 때문

    }

    void SayHello()
    {
        Debug.Log("Hello");
    }

    void SayHello2()
    {
        Debug.Log("Hello2");
    }
}

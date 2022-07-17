using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Delegate_event : MonoBehaviour
{

    //delegate : �޼ҵ带 ��� ������ Ÿ��, ���൵ ������
    delegate void sayHello();
    delegate void sayHello2();
    delegate void sayHello3();

    void Start()
    {
        //���Խ� �ٷ� ����
        sayHello hello = new sayHello(SayHello);
        sayHello2 hello2 = SayHello2;

        sayHello2 hello3 = SayHello;
        hello3 += SayHello2;//��Ƽ ĳ��Ʈ

        hello();
        hello2();//������ �ȵǴ� ���� : ���� �׳� �޼ҵ��̱� ����

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

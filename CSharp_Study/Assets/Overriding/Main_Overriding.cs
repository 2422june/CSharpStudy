using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Main_Overriding : MonoBehaviour
{
    June_Overriding j1;
    Human_Overriding h1;

    June_Overriding j2;
    Human_Overriding h2;

    #region �������̵�

    //�Ű������� �޶� �ٸ� �޼ҵ�� �����Ѵ�.
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
        //j2 = new Human_Overriding("a2"); ����
        h1 = new Human_Overriding("a3");
        h2 = new June_Overriding("a4");


        //�Ѵ� ���� �ؿ��Ը� ������ �ޱ⿡ �Ѵ� ȿ���� �����Ѵ�.

        j1.Saying("It's Inheritance");
        //j1.Shouting("It's Inheritance");
        j1.Howling("It's Inheritance");
        //j1.Bowing("It's Inheritance");


        Debug.Log("====================");

        //�Ѵ� june���� ������ ���⿡ � ȿ���� ����.

        h1.Saying("It's Inheritance");
        //h1.Shouting("It's Inheritance");
        h1.Howling("It's Inheritance");
        //h1.Bowing("It's Inheritance");

        Debug.Log("====================");

        //������ �Ǿ��⿡ ȿ���� �����Ѵ�.
        h2.Saying("It's Inheritance");
        //h2.Shouting("It's Inheritance");

        // june���� ���ο� �Լ��� ���� �� �̱⿡ ȿ���� ���� �� �Ѵ�.
        //������ �̰� �ָ��ϴ�. (human���� ���� �޼ҵ�� �� �޾� �� �ǰ�?)
        h2.Howling("It's Inheritance"); 
        //h2.Bowing("It's Inheritance");

        Debug.Log("====================");
    }
}

class June_Overriding : Human_Overriding//���
{

    public override void Saying(string syntex)//�޼ҵ� ������
    {
        Debug.Log("It's Override");
    }
    public override void Shouting(string syntex)//�޼ҵ� ������
    {
        Debug.Log("It's Override");
        base.Shouting(syntex);//�θ��� �޼ҵ� ȣ��
    }

    public new void Howling(string syntex) //�żҵ� �缱��
    {
        Debug.Log("It's New");
    }
    public new void Bowing(string syntex) //�żҵ� �缱��
    {
        Debug.Log("It's New");
        base.Bowing(syntex);
    }

    public June_Overriding(string name) : base(name)
    {

    }
}

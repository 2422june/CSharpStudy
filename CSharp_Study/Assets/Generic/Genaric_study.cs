using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Genaric_study : MonoBehaviour
{
    GenericClass_1<int> GC1;
    GenericClass_1<float> GC2;
    GenericClass_2<Transform> GC3;

    private void Start()
    {
        GC1 = new GenericClass_1<int>();
        GC2 = new GenericClass_1<float>();
        GC3 = new GenericClass_2<Transform>();

        GC1.data = 1;
        GC2.data = 1f;
        GC3.data = this.transform;

        //GC3.data = 1; ����
    }
}

class GenericClass_1<T>//generic�� Ŭ���� ���� �ٿ��� ����Ѵ�.
{
    //������ Ÿ���� �̸� ������ �ʰ� ���������� ����ϴ� ��. generic�̴�.
    public T data;
}


//T�� transform������ ���� (Ŭ����, struct ź���� ����)
class GenericClass_2<T> where T : Transform
{
    public T data;
}
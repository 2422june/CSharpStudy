using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class static_study : MonoBehaviour
{
    static_class sc;

    private void Start()
    {
        sc = new static_class();
        //sc.number = 1; //����
        //(���� : sc���� number�� ���� �����̴�.)
        //number�� static_class�� �ִ�.
        static_class.number = 1;
    }
}

class static_class
{
    //static�� �����ǰų� �������� �ʴ´�.
    //�׾߸��� �����ϸ� �������� �ʴ´�.
    //���� ����???
    public static int number;
}
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Main_InterFace : I_Study1, I_Study2 //���� ��Ӱ���
{

    //��� ���Ǵ� �ʼ���, ��ȣ������ public���� �����̴�

    public string _name // ��������!
    {
        get
        {
            return _name;
        }

        set 
        {
            _name = value;
        }
    }

    public void Attack() // ��������!
    {

    }
}

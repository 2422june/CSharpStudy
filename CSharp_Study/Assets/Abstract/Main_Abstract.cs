using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Main_Abstract : MonoBehaviour
{
    June_Abstract j1 = new June_Abstract();

    private void Start()
    {
        j1.Saying("Hello");
    }
}

class June_Abstract : Human_Abstract//���
{

    public override void Saying(string syntex)//���� �޼ҵ� ���� (�ʼ�)
    {
        Debug.Log("It's Override");
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HashTable_study : MonoBehaviour
{
    //�ڽ� ��ڽ� �̽� ���� generic���� �ذ� �����ϴ�
    Hashtable ht = new Hashtable();// dictionary�� ��� Ÿ�� ����

    Dictionary<string, int> d = new Dictionary<string, int>();

    GameObject a;

    void Start()
    {
        ht.Add("a", a);
        ht.Add("b", 1);
        ht.Add("c", 1.1f);
    }

}

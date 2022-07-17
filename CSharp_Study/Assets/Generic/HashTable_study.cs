using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HashTable_study : MonoBehaviour
{
    //박싱 언박싱 이슈 있음 generic으로 해결 가능하다
    Hashtable ht = new Hashtable();// dictionary의 모든 타입 버전

    Dictionary<string, int> d = new Dictionary<string, int>();

    GameObject a;

    void Start()
    {
        ht.Add("a", a);
        ht.Add("b", 1);
        ht.Add("c", 1.1f);
    }

}

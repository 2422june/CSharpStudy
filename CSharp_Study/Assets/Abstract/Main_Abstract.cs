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

class June_Abstract : Human_Abstract//상속
{

    public override void Saying(string syntex)//가상 메소드 정의 (필수)
    {
        Debug.Log("It's Override");
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

interface I_Study1
{
    //변수가 저장되지 않음.
    string _name { get; set; }

    //모든 함수들이 가상 메소드임
    void Attack();
}

interface I_Study2
{
    //변수가 저장되지 않음.
    string _name { get; set; }

    //모든 함수들이 가상 메소드임
    void Attack();
}
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Main_InterFace : I_Study1, I_Study2 //다중 상속가능
{

    //모든 정의는 필수며, 보호수준은 public으로 고정이다

    public string _name // 곂쳐졌다!
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

    public void Attack() // 곂쳐졌다!
    {

    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class static_study : MonoBehaviour
{
    static_class sc;

    private void Start()
    {
        sc = new static_class();
        //sc.number = 1; //에러
        //(이유 : sc에는 number가 없기 때문이다.)
        //number는 static_class에 있다.
        static_class.number = 1;
    }
}

class static_class
{
    //static은 복제되거나 나눠지지 않는다.
    //그야말로 유일하며 움직이지 않는다.
    //공용 변수???
    public static int number;
}
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

        //GC3.data = 1; 에러
    }
}

class GenericClass_1<T>//generic은 클래스 옆에 붙여서 사용한다.
{
    //데이터 타입을 미리 정하지 않고 유동적으로 사용하는 것. generic이다.
    public T data;
}


//T를 transform형으로 제약 (클래스, struct 탄위만 가능)
class GenericClass_2<T> where T : Transform
{
    public T data;
}
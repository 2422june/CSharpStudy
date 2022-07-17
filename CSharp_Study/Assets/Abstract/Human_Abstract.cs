using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Human_Abstract : MonoBehaviour
//추상 메소드가 있을 시 abstract를 앞에 붙여야함
{

    //추상 메소드(abstract)는 부모에서 정의만 할 수 있다.
    public abstract void Saying(string syntex);

    public virtual void Shouting(string syntex)
    {
        Debug.Log(syntex);
    }

    public void Howling(string syntex)
    {
        Debug.Log(syntex);
    }
}

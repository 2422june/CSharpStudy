using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Human_Abstract : MonoBehaviour
//�߻� �޼ҵ尡 ���� �� abstract�� �տ� �ٿ�����
{

    //�߻� �޼ҵ�(abstract)�� �θ𿡼� ���Ǹ� �� �� �ִ�.
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

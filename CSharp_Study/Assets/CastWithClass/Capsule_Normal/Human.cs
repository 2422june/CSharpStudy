using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//�߻�ȭ, ĸ��ȭ
#region Ŭ����
public class Human : MonoBehaviour
{
    #region �Ӽ���
    #region ����
    /* Get Set Property (���м��� ĸ��ȭ�� ���´�.)
     * 
     * ���� �ڷ��� �̸�(���� ����)
     * 
     * public �ڷ��� �̸�(�޼ҵ� ����)
     * {
     *     get
     *     {
     *         ���� ��ɵ�
     *     }
     *     
     *     get�� �޼ҵ�� �ϸ�
     *     Public �ڷ��� Get()
     *     {
     *         ���� ��ɵ�
     *     }
     *     �� �ȴ�.
     *==========================================
     *     set
     *     {
     *         ���� ��ɵ�
     *         value == �Է°��̴�
     *     }
     * 
     *     set�� �޼ҵ�� �ϸ�
     *     public void Set(�ڷ��� value)
     *     {
     *         ���� ��ɵ�
     *     }
     *     �� �ȴ�.
     * }
     */
    #endregion

    private int _age;
    public int Age
    {
        get
        {
            Debug.Log("Get");
            return _age;
        }

        set
        {
            Debug.Log("Set");
            _age = value;
        }
    }

    private float _height;
    public float Height
    {
        get
        {
            return _height;
        }

        set
        {
            _height = value;
        }
    }

    private float _weight;
    public float Weight
    {
        get
        {
            return _weight;
        }

        set
        {
            _weight = value;
        }
    }

    private string _name;
    public string Name
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

    private string _job;
    public string Job
    {
        get
        {
            return _job;
        }

        set
        {
            _job = value;
        }
    }
    #endregion



    /* Shape of method
     * 
     * ���� MethodName(�Ķ����)
     * {
     *     ��ɵ�
     * }
     * 
     */



    #region ������
    //��� ��Ű�� �ʰ� �ٸ� Ŭ�������� ����� �� �̱⿡ public�� ����ؾ� �����ڸ� ȣ�� ��ų �� �ִ�.
    public Human(string name, int age, string job, float height, float weight)
    {
        #region �ʱ�ȭ
        _name = name;
        _age = age;
        _job = job;
        _height = height;
        _weight = weight;
        #endregion
    }
    #endregion

    
}
#endregion

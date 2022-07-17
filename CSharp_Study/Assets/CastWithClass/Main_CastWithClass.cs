using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Main_CastWithClass : MonoBehaviour//���
{
    June_CastWithClass j1;
    Human_CastWithClass h1;

    June_CastWithClass j2;
    Human_CastWithClass h2;

    June_CastWithClass j3;
    Human_CastWithClass h3;

    June_CastWithClass j4;
    Human_CastWithClass h4;

    void Start()
    {
        j1 = new June_CastWithClass("a1", 1, null);
        j2 = new June_CastWithClass("a2", 1, null);
        j3 = new June_CastWithClass("a3", 1, null);
        j4 = new June_CastWithClass("a4", 1, null);


        #region �Ͻ��� ����ȯ

        h1 = j1; //�ڽ��� �θ�� ĳ���� �ϴ°� �����ϴ�.
        //j = h; //�θ� �ڽ����� ĳ���� �ϴ°� �Ұ��� �ϴ�.(�ּ�Ǯ�� ������ ��.)
        #endregion

        #region ����� ����ȯ (���. 1)

        j2 = (June_CastWithClass)h2; //����� ���� ����.
        h2 = (Human_CastWithClass)j2; //���� ������ �ȳ�, ��� null����

        if (h2 == null)
        {
            Debug.Log("h2 is null");
        }
        #endregion

        #region ����� ����ȯ (���. 2)

        //as Ű����� ĳ���� Ű����� �����ض� (Ŭ�������� ��� �����ϴ�.)
        j3 = h3 as June_CastWithClass;
        h3 = j3 as June_CastWithClass;

        if (h3 == null)
        {
            Debug.Log("h3 is null");
        }
        #endregion

        #region ĳ������ �������� Ȯ���ϴ� ���

        //is Ű�����  a is b��� �Ҷ� a�� b�� ����ȯ �� �� �ִ��� ���θ� �����Ѵ�.
        Debug.Log((j4 is Human_CastWithClass));
        Debug.Log((h4 is June_CastWithClass));

        #endregion

        // �ڽ��� �θ��� ��� �Ӽ��� ��ӹ޾� ���� ������,
        // �θ�� �ڽ��� ���� ������ ���� �Ӽ����� ���� ���� �ʱ⿡.
        // �θ� �ڽ����� ĳ���� �Ǵ� �� �� �翬�� �Ͼ �� ����.
    }
}

class June_CastWithClass : Human_CastWithClass//���
{
    int _age;


    public int sayThisAge()
    {
        this._age = 10;
        return this._age;
        //this�� �ڱ��ڽ��� �Ӽ��� �����Ѵ�.
    }
    public int sayBaseAge()
    {
        return base._age;
        //base�� �θ��� �Ӽ��� �����Ѵ�.
    }

    public June_CastWithClass(string name, int age, string job) : base(name, age, job)
    {
        /* ������ �޼ҵ��� ��� (�� ����� �����ϸ� �޼ҵ� ������ ��ӵ� �� ����.)
         * 
         * ���� 1. �� ������ �ش��ϴ� �Ķ������ �̸��� ���� ��.
         * ���� 2. �� ������ �ش��ϴ� �Ķ������ �ڷ����� ���� ��.
         * ���� 3. ������ �� ��.
         * ���� 4. ����� ���� baseŰ����� �����ڿ� ������ ��.
         * 
         * ���� ���ǵ��� �����ɽ� �����ڴ�
         * �θ��� �������� ����� ��ӵȴ�.
         * 
         */
    }
}

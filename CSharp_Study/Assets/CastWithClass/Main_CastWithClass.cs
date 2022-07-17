using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Main_CastWithClass : MonoBehaviour//상속
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


        #region 암시적 형변환

        h1 = j1; //자식을 부모로 캐스팅 하는건 가능하다.
        //j = h; //부모를 자식으로 캐스팅 하는건 불가능 하다.(주석풀면 에러날 것.)
        #endregion

        #region 명시적 형변환 (방법. 1)

        j2 = (June_CastWithClass)h2; //결과는 위와 같다.
        h2 = (Human_CastWithClass)j2; //왠지 에러가 안남, 대신 null값임

        if (h2 == null)
        {
            Debug.Log("h2 is null");
        }
        #endregion

        #region 명시적 형변환 (방법. 2)

        //as 키워드는 캐스팅 키워드라 생각해라 (클래스에만 사용 가능하다.)
        j3 = h3 as June_CastWithClass;
        h3 = j3 as June_CastWithClass;

        if (h3 == null)
        {
            Debug.Log("h3 is null");
        }
        #endregion

        #region 캐스팅이 가능한지 확인하는 방법

        //is 키워드는  a is b라고 할때 a가 b로 형뱐환 될 수 있는지 여부를 리턴한다.
        Debug.Log((j4 is Human_CastWithClass));
        Debug.Log((h4 is June_CastWithClass));

        #endregion

        // 자식은 부모의 모든 속성을 상속받아 갖고 있으나,
        // 부모는 자식이 따로 정의해 갖는 속성등을 갖고 있지 않기에.
        // 부모가 자식으로 캐스팅 되는 것 은 당연히 일어날 수 없다.
    }
}

class June_CastWithClass : Human_CastWithClass//상속
{
    int _age;


    public int sayThisAge()
    {
        this._age = 10;
        return this._age;
        //this는 자기자신의 속성에 접근한다.
    }
    public int sayBaseAge()
    {
        return base._age;
        //base는 부모의 속성에 접근한다.
    }

    public June_CastWithClass(string name, int age, string job) : base(name, age, job)
    {
        /* 생성자 메소드의 상속 (이 기능을 제외하면 메소드 끼리는 상속될 수 없다.)
         * 
         * 조건 1. 각 순서에 해당하는 파라매터의 이름이 같을 것.
         * 조건 2. 각 순서에 해당하는 파라매터의 자료형이 같을 것.
         * 조건 3. 생성자 일 것.
         * 조건 4. 상속을 톻해 base키워드로 생성자에 접근할 것.
         * 
         * 위의 조건들이 성립될시 생성자는
         * 부모의 생성자의 기능이 상속된다.
         * 
         */
    }
}

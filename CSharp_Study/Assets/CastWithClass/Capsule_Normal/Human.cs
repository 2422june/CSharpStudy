using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//추상화, 캡슐화
#region 클래스
public class Human : MonoBehaviour
{
    #region 속성들
    #region 설명
    /* Get Set Property (은닉성과 캡슐화를 돕는다.)
     * 
     * 범위 자료형 이름(변수 선언)
     * 
     * public 자료형 이름(메소드 선언)
     * {
     *     get
     *     {
     *         여러 기능들
     *     }
     *     
     *     get을 메소드로 하면
     *     Public 자료형 Get()
     *     {
     *         여러 기능들
     *     }
     *     이 된다.
     *==========================================
     *     set
     *     {
     *         여러 기능들
     *         value == 입력값이다
     *     }
     * 
     *     set을 메소드로 하면
     *     public void Set(자료형 value)
     *     {
     *         여러 기능들
     *     }
     *     이 된다.
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
     * 범위 MethodName(파라매터)
     * {
     *     기능들
     * }
     * 
     */



    #region 생성자
    //상속 시키지 않고 다른 클래스에서 사용할 것 이기에 public을 사용해야 생성자를 호출 시킬 수 있다.
    public Human(string name, int age, string job, float height, float weight)
    {
        #region 초기화
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

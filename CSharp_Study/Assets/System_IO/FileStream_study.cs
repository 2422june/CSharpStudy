using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;

public class FileStream_study : MonoBehaviour
{
    FileStream fs1; //제어자(생성, 접근)
    FileStream fs2; 
    StreamWriter sw1;//편집자
    StreamReader sr1;//인식자

    /// <summary>
    /// description
    /// </summary>
    /// 
    /// <param> 1줄 설명 </param>
    /// 
    /// https://obliquelab.tistory.com/21



    private void Start()
    {
        fs1 = new FileStream("C:Users/User/Desktop/test.txt", FileMode.Create);
        /*
         * FileMode.Create : 새로 만들지만 기존에 있으면 덮어씌움
         */

        sw1 = new StreamWriter(fs1);

        sw1.Write("Hello");//텍스트 기입
        sw1.Close();//파일 작성

        fs2 = new FileStream("C:Users/User/Desktop/test.txt", FileMode.Open);
        sr1 = new StreamReader(fs2);
        Debug.Log(sr1.ReadLine());//파일 읽기

        sr1.Close();//
    }
}

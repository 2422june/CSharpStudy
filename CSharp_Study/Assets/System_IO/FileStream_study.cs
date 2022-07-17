using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;

public class FileStream_study : MonoBehaviour
{
    FileStream fs1; //������(����, ����)
    FileStream fs2; 
    StreamWriter sw1;//������
    StreamReader sr1;//�ν���

    /// <summary>
    /// description
    /// </summary>
    /// 
    /// <param> 1�� ���� </param>
    /// 
    /// https://obliquelab.tistory.com/21



    private void Start()
    {
        fs1 = new FileStream("C:Users/User/Desktop/test.txt", FileMode.Create);
        /*
         * FileMode.Create : ���� �������� ������ ������ �����
         */

        sw1 = new StreamWriter(fs1);

        sw1.Write("Hello");//�ؽ�Ʈ ����
        sw1.Close();//���� �ۼ�

        fs2 = new FileStream("C:Users/User/Desktop/test.txt", FileMode.Open);
        sr1 = new StreamReader(fs2);
        Debug.Log(sr1.ReadLine());//���� �б�

        sr1.Close();//
    }
}

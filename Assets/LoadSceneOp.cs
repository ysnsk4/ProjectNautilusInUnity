//using System.Collections;
//using System.Collections.Generic;
//using UnityEngine;
//using UnityEngine.SceneManagement; // UnityEngine.SceneManagemnt�̋@�\���g�p

//public class ToSampleScene : MonoBehaviour
//{
//    int SceneNub = 0;
//    //0:�^�C�g��,1:�������,2:�v���C���,3:�N���A���

//    // ���ɋL�q���ꂽ���������Ԋu�ŌJ��Ԃ����s�����
//    void Update()
//    {
//        // �������͂����L�[��Space�L�[�Ȃ�΁A���̏��������s����

//        //�^�C�g��
//        if (SceneNub == 0)
//        {
//            if (Input.GetKeyDown(KeyCode.Space))
//            {
//                SceneManager.LoadScene("OperationScene");
//                SceneNub = 1;
//            }
//        }

//        //�������
//        if (SceneNub == 1)
//        {
//            if (Input.GetKeyDown(KeyCode.Space))
//            {
//                SceneManager.LoadScene("SampleScene");
//                SceneNub = 2;
//            }
//        }

//        //�v���C���
//        if (SceneNub == 2)
//        {
//            if (Input.GetKeyDown(KeyCode.Space))
//            {
//                SceneManager.LoadScene("ClearScene");
//                SceneNub = 3;
//            }
//        }

//        //�N���A���
//        if (SceneNub == 3)
//        {
//            if (Input.GetKeyDown(KeyCode.Space))
//            {
//                SceneManager.LoadScene("TitleScene");
//                SceneNub = 0;
//            }
//        }
//    }
//}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement; // UnityEngine.SceneManagemnt�̋@�\���g�p

public class ToOperationScene : MonoBehaviour
{
    // ���ɋL�q���ꂽ���������Ԋu�ŌJ��Ԃ����s�����
    void Update()
    {
        // �������͂����L�[��Space�L�[�Ȃ�΁A���̏��������s����
        if (Input.GetKeyDown(KeyCode.Space))
        {
            // SampleScene�ɐ؂�ւ���
            SceneManager.LoadScene("OperationScene");
        }
    }
}
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement; // UnityEngine.SceneManagemnt�̋@�\���g�p

public class ToTitleScene : MonoBehaviour
{
    // ���ɋL�q���ꂽ���������Ԋu�ŌJ��Ԃ����s�����
    void Update()
    {
        // �������͂����L�[��Space�L�[�Ȃ�΁A���̏��������s����
        if (Input.GetKeyDown(KeyCode.Space))
        {
            // SampleScene�ɐ؂�ւ���
            SceneManager.LoadScene("TitleScene");
        }
    }
}
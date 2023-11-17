using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MissileMoveScript : MonoBehaviour
{
    public GameObject Rock; //��̃I�u�W�F�N�g
    public GameObject Missile; //�I���W�i���̃I�u�W�F�N�g
    int missileFlag = 0;
    int missileAdvance = 0;
    int missileDistance = 0;
    //int missileCount = 0;

    //// �C���X�^���X������Prefab�I�u�W�F�N�g���A�T�C�����܂��B
    //public GameObject prefab;

    //// �e�I�u�W�F�N�g�̃g�����X�t�H�[�����A�T�C�����܂��B
    //public Transform parentTran;

    //// �Q�[���I�u�W�F�N�g�𐶐����鐔���w�肵�܂��B
    //public int prefabNum;

    // Start is called before the first frame update
    void Start()
    {
        
        //Instantiate(Missile1, new Vector3(-1.0f, 0.0f, 0.0f), Quaternion.identity);
    }

    //[SerializeField] GameObject CubePrefab;

    // Update is called once per frame
    void Update()
    {
        Vector3 pos = transform.position;

        
        if (missileFlag == 0)
        {
            if (Input.GetKeyDown(KeyCode.Z))
            {
                //InstantiatePrefab();
                Instantiate(Missile, new Vector3(0.0f, -1.0f, -1.0f), Quaternion.AngleAxis(270,Vector3.up));
                missileFlag = 1;
                missileAdvance = 1;
            }
        }

        if (missileFlag == 1)
        {
            if (missileAdvance == 1)
            {
                pos.z = pos.z + 0.1f;
                //pos.x = pos.x;
                missileDistance += 1;
            }
            if (missileDistance >= 500)
            {
                missileFlag = 0;
                missileAdvance = 0;
                missileDistance = 0;
                //missileCount = 0;
                Destroy(Missile);
            }
        }
       
        transform.position = new Vector3(pos.x, pos.y, pos.z);
        transform.position.Normalize();
    }

    void OnCollisionEnter()
    {
        Debug.Log("Hit"); // ���O��\������
        missileFlag = 0;
        missileAdvance = 0;
        missileDistance = 0;
        //missileCount = 0;
        Destroy(Missile);
    }


    /// <Summary>
    /// �Q�[���I�u�W�F�N�g��Prefab����쐬���鏈���ł��B
    /// </Summary>
    //void InstantiatePrefab()
    //{
    //    for (int i = 0; i < prefabNum; i++)
    //    {
    //        GameObject obj = Instantiate(prefab, new Vector3(0.0f, -1.0f, -1.0f), Quaternion.AngleAxis(270, Vector3.up));
    //        //GameObject obj = Instantiate(prefab, Vector3.zero, Quaternion.identity);
    //        obj.transform.SetParent(parentTran);
    //        obj.transform.position = new Vector3(i, 0f, 0f);
    //    }
    //}
}

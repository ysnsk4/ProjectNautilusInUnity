using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MissileMoveScript : MonoBehaviour
{
    public GameObject Rock; //��̃I�u�W�F�N�g
    public int missileAdvance = 1;
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


        //if (missileFlag == 0)
        //{
        //    if (Input.GetKeyDown(KeyCode.Z))
        //    {
        //        //InstantiatePrefab();
        //        Instantiate(Missile, new Vector3(0.0f, -1.0f, -1.0f), Quaternion.AngleAxis(270, Vector3.up));
        //        missileFlag = 1;
        //        missileAdvance = 1;
        //    }
        //}

        if (missileAdvance == 1)
        {
            pos.z += 0.20f;
            //pos.x = pos.x;
            missileDistance += 1;
        }
        if (missileDistance >= 500)
        {
            missileAdvance = 0;
            missileDistance = 0;
            //missileCount = 0;
            //Destroy(gameObject);
        }

        transform.position = new Vector3(pos.x, pos.y, pos.z);
        //transform.position.Normalize();
    }

    void OnCollisionEnter(Collision collision)
    {
        Debug.Log("Hit"); // ���O��\������
        Debug.Log(collision.gameObject.name); // �Ԃ���������̖��O���擾

        //if()

        missileAdvance = 0;
        missileDistance = 0;
        //missileCount = 0;
        //Destroy(gameObject);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "breakable_rock")
        {
            other.GetComponent<BreakRock>().Damage();
            missileAdvance = 0;
            missileDistance = 0;
        }
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

//using UnityEngine;

//public class FireBullet : MonoBehaviour
//{
//    [SerializeField]
//    [Tooltip("�e�̔��ˏꏊ")]
//    private GameObject firingPoint;

//    [SerializeField]
//    [Tooltip("�e")]
//    private GameObject bullet;

//    [SerializeField]
//    [Tooltip("�e�̑���")]
//    private float speed = 30f;

//     Update is called once per frame
//    void Update()
//    {
//         �X�y�[�X�L�[�������ꂽ���𔻒�
//        if (Input.GetKeyDown(KeyCode.Z))
//        {
//             �e�𔭎˂���
//            LauncherShot();
//        }
//    }

//    / <summary>
//	/ �e�̔���
//	/ </summary>
//    private void LauncherShot()
//    {
//         �e�𔭎˂���ꏊ���擾
//        Vector3 bulletPosition = firingPoint.transform.position;
//         ��Ŏ擾�����ꏊ�ɁA"bullet"��Prefab���o��������
//        GameObject newBall = Instantiate(bullet, bulletPosition, transform.rotation);
//         �o���������{�[����forward(z������)
//        Vector3 direction = newBall.transform.forward;
//         �e�̔��˕�����newBall��z����(���[�J�����W)�����A�e�I�u�W�F�N�g��rigidbody�ɏՌ��͂�������
//        newBall.GetComponent<Rigidbody>().AddForce(direction * speed, ForceMode.Impulse);
//         �o���������{�[���̖��O��"bullet"�ɕύX
//        newBall.name = bullet.name;
//         �o���������{�[����0.8�b��ɏ���
//        Destroy(newBall, 0.8f);
//    }
//}
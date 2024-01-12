using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    [SerializeField] GameObject Player;
    //private Vector3 angle;
    //private Vector3 primary_angle;

    // Start is called before the first frame update
    void Start()
    {
        //angle = this.gameObject.transform.localEulerAngles;
        //primary_angle = this.gameObject.transform.localEulerAngles;
    }

    // Update is called once per frame
    void Update()
    {
        //Vector3 pos = transform.position;

        float mx = Input.GetAxis("Mouse X");
        float my = Input.GetAxis("Mouse Y");


        if (Input.GetMouseButton(0))
        {
            if (Mathf.Abs(mx) > 0.1f)
            {
<<<<<<< HEAD
                // ��]���̓��[���h���W��Y��
                transform.RotateAround(Player.transform.position, Vector3.up, mx * 2);
=======
                // 回転軸はワールド座標�EY軸
                transform.RotateAround(Player.transform.position, Vector3.up, mx*2);
>>>>>>> c27ec95b9f4b753fc7d2c5f8816fa1afa0a98618
            }
        //}

<<<<<<< HEAD
        if (Input.GetMouseButton(0))
        {
            // Y�����Ɉ��ʈړ����Ă���Ώc��]
            if (Mathf.Abs(my) > 0.1f)
            {
                // ��]���̓J�������g��X��
                transform.RotateAround(Player.transform.position, transform.right, -my * 2);
=======
        //if (Input.GetKey(KeyCode.I))
        //{
        //    my = 1.0f;
        //}
        //if (Input.GetKey(KeyCode.K))
        //{
        //    my = -1.0f;
        //}
        //if(my>0)
        //{
        //    if (transform.rotation.z + my > 90)
        //    {
        //        my = 90 - transform.rotation.z;
        //    }
        //}
        //if (my < 0)
        //{
        //    if (transform.rotation.z + my < -90)
        //    {
        //        my = -90 - transform.rotation.z;
        //    }
        //}

        //if (Input.GetMouseButton(0))
        //{
            // Y方向に一定量移動してぁE��ば縦回転
            if (Mathf.Abs(my) > 0.1f)
            {
                    // 回転軸はカメラ自身のX軸
                transform.RotateAround(Player.transform.position, transform.right, -my*2);
>>>>>>> c27ec95b9f4b753fc7d2c5f8816fa1afa0a98618
            }
        //}


    }
}

//------------------------

//using System.Collections;
//using System.Collections.Generic;
//using UnityEngine;

//public class CameraController : MonoBehaviour
//{
//    [Header("�ǐՂ���Q�[���I�u�W�F�N�g")]
//    public GameObject targetObj;

//    private Vector3 targetPos;                  // targetObj �ϐ��̃Q�[���I�u�W�F�N�g�̈ʒu���L�^����ϐ�

//    [SerializeField]
//    private float cameraRotateSpeed = 200f;     // �J�����̉�]���x

//    [SerializeField]
//    private float maxLimit = 30.0f;             // X �������̉��͈�

//    private float minLimit;


//    void Start()
//    {
//        // �Ǐ]�Ώ�(targetObj)�̈ʒu�����擾
//        targetPos = targetObj.transform.position;

//        // X ���̉��͈͂̐ݒ�
//        minLimit = 360 - maxLimit;
//    }

//    void Update()
//    {
//        // �Ǐ]�Ώۂ�����ꍇ
//        if (targetObj != null)
//        {

//            // �J�����̈ʒu���A�Ǐ]�Ώۂ̈ʒu - �␳�l(targetPos)�ɂ��āA��苗������ĒǏ]������
//            transform.position += targetObj.transform.position - targetPos;

//            // �Ǐ]�Ώ�(targetObj)�̈ʒu�����X�V
//            targetPos = targetObj.transform.position;
//        }

//        if (Input.GetMouseButton(1))
//        {
//            // �J�����̉�]
//            RotateCamera();
//        }
//    }

//    /// <summary>
//    /// targetObj �����ɂ����J�����̌��]��]
//    /// </summary>
//    private void RotateCamera()
//    {

//        // �}�E�X�̓��͒l���擾
//        float x = Input.GetAxis("Mouse X");
//        float z = Input.GetAxis("Mouse Y");

//        // �J������Ǐ]�Ώۂ̎��͂����]��]������
//        transform.RotateAround(targetObj.transform.position, Vector3.up, x * Time.deltaTime * cameraRotateSpeed);

//        //�J�����̉�]���̏����l���Z�b�g
//        var localAngle = transform.localEulerAngles;

//        // X ���̉�]�����Z�b�g
//        localAngle.x += z;

//        // X �����ғ��͈͓��Ɏ��܂�悤�ɐ���
//        if (localAngle.x > maxLimit && localAngle.x < 180)
//        {
//            localAngle.x = maxLimit;
//        }

//        if (localAngle.x < minLimit && localAngle.x > 180)
//        {
//            localAngle.x = minLimit;
//        }

//        // �J�����̉�]
//        transform.localEulerAngles = localAngle;
//    }
//}

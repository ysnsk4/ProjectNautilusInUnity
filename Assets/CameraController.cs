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
                // 回転軸はワールド座標のY軸
                transform.RotateAround(Player.transform.position, Vector3.up, mx * 2);
            }
        }

        if (Input.GetMouseButton(0))
        {
            // Y方向に一定量移動していれば縦回転
            if (Mathf.Abs(my) > 0.1f)
            {
                // 回転軸はカメラ自身のX軸
                transform.RotateAround(Player.transform.position, transform.right, -my * 2);
            }
        }


    }
}

//------------------------

//using System.Collections;
//using System.Collections.Generic;
//using UnityEngine;

//public class CameraController : MonoBehaviour
//{
//    [Header("追跡するゲームオブジェクト")]
//    public GameObject targetObj;

//    private Vector3 targetPos;                  // targetObj 変数のゲームオブジェクトの位置を記録する変数

//    [SerializeField]
//    private float cameraRotateSpeed = 200f;     // カメラの回転速度

//    [SerializeField]
//    private float maxLimit = 30.0f;             // X 軸方向の可動範囲

//    private float minLimit;


//    void Start()
//    {
//        // 追従対象(targetObj)の位置情報を取得
//        targetPos = targetObj.transform.position;

//        // X 軸の可動範囲の設定
//        minLimit = 360 - maxLimit;
//    }

//    void Update()
//    {
//        // 追従対象がいる場合
//        if (targetObj != null)
//        {

//            // カメラの位置を、追従対象の位置 - 補正値(targetPos)にして、一定距離離れて追従させる
//            transform.position += targetObj.transform.position - targetPos;

//            // 追従対象(targetObj)の位置情報を更新
//            targetPos = targetObj.transform.position;
//        }

//        if (Input.GetMouseButton(1))
//        {
//            // カメラの回転
//            RotateCamera();
//        }
//    }

//    /// <summary>
//    /// targetObj を軸にしたカメラの公転回転
//    /// </summary>
//    private void RotateCamera()
//    {

//        // マウスの入力値を取得
//        float x = Input.GetAxis("Mouse X");
//        float z = Input.GetAxis("Mouse Y");

//        // カメラを追従対象の周囲を公転回転させる
//        transform.RotateAround(targetObj.transform.position, Vector3.up, x * Time.deltaTime * cameraRotateSpeed);

//        //カメラの回転情報の初期値をセット
//        var localAngle = transform.localEulerAngles;

//        // X 軸の回転情報をセット
//        localAngle.x += z;

//        // X 軸を稼働範囲内に収まるように制御
//        if (localAngle.x > maxLimit && localAngle.x < 180)
//        {
//            localAngle.x = maxLimit;
//        }

//        if (localAngle.x < minLimit && localAngle.x > 180)
//        {
//            localAngle.x = minLimit;
//        }

//        // カメラの回転
//        transform.localEulerAngles = localAngle;
//    }
//}

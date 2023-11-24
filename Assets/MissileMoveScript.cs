using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MissileMoveScript : MonoBehaviour
{
    public GameObject Rock; //岩のオブジェクト
    public int missileAdvance = 1;
    int missileDistance = 0;
    //int missileCount = 0;

    //// インスタンス化するPrefabオブジェクトをアサインします。
    //public GameObject prefab;

    //// 親オブジェクトのトランスフォームをアサインします。
    //public Transform parentTran;

    //// ゲームオブジェクトを生成する数を指定します。
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
        Debug.Log("Hit"); // ログを表示する
        Debug.Log(collision.gameObject.name); // ぶつかった相手の名前を取得

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
    /// ゲームオブジェクトをPrefabから作成する処理です。
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
//    [Tooltip("弾の発射場所")]
//    private GameObject firingPoint;

//    [SerializeField]
//    [Tooltip("弾")]
//    private GameObject bullet;

//    [SerializeField]
//    [Tooltip("弾の速さ")]
//    private float speed = 30f;

//     Update is called once per frame
//    void Update()
//    {
//         スペースキーが押されたかを判定
//        if (Input.GetKeyDown(KeyCode.Z))
//        {
//             弾を発射する
//            LauncherShot();
//        }
//    }

//    / <summary>
//	/ 弾の発射
//	/ </summary>
//    private void LauncherShot()
//    {
//         弾を発射する場所を取得
//        Vector3 bulletPosition = firingPoint.transform.position;
//         上で取得した場所に、"bullet"のPrefabを出現させる
//        GameObject newBall = Instantiate(bullet, bulletPosition, transform.rotation);
//         出現させたボールのforward(z軸方向)
//        Vector3 direction = newBall.transform.forward;
//         弾の発射方向にnewBallのz方向(ローカル座標)を入れ、弾オブジェクトのrigidbodyに衝撃力を加える
//        newBall.GetComponent<Rigidbody>().AddForce(direction * speed, ForceMode.Impulse);
//         出現させたボールの名前を"bullet"に変更
//        newBall.name = bullet.name;
//         出現させたボールを0.8秒後に消す
//        Destroy(newBall, 0.8f);
//    }
//}
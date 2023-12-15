using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement; // UnityEngine.SceneManagemntの機能を使用

public class PlayerController : MonoBehaviour
{

    public MissileMoveScript Missile; //オリジナルのオブジェクト
    private MissileMoveScript currentMisile;

    public static int GoldCount = 0;
    int ClearFlag = 0;

    //[SerializeField]
    //private float _speed = 1f;

    void Start()
    {
        GoldCount = 0;
        ClearFlag = 0;
    }

    // Update is called once per frame

    /// <summary>
    /// 衝突した時
    /// </summary>
    /// <param name="collision"></param>
    void OnCollisionEnter(Collision collision)
    {
        // 衝突した相手にPlayerタグが付いているとき
        if (collision.gameObject.tag == "GetGold")
        {
            GoldCount += 1;
        }
    }

        void Update()
    {

        Vector3 pos = transform.position;

        if (GoldCount >= 3)
        {
            ClearFlag = 1;
        }

        if (ClearFlag == 1 && pos.z > 200)
        {
            // SampleSceneに切り替える
            SceneManager.LoadScene("ClearScene");
            Start();
        }


        if (Input.GetKey(KeyCode.RightArrow) || Input.GetKey(KeyCode.D))
        {
            pos.x += 0.05f;
        }

        if (Input.GetKey(KeyCode.LeftArrow) || Input.GetKey(KeyCode.A))
        {
            pos.x -= 0.05f;
        }

        if (Input.GetKey(KeyCode.UpArrow) || Input.GetKey(KeyCode.W))
        {
            pos.z += 0.05f;
        }

        if (Input.GetKey(KeyCode.DownArrow) || Input.GetKey(KeyCode.S))
        {
            pos.z -= 0.05f;
        }




        if (Input.GetKey(KeyCode.Space))
        {
            pos.y += 0.03f;
        }
        if (Input.GetKey(KeyCode.LeftShift))
        {
            pos.y -= 0.03f;
        }

        if (!currentMisile)
        {
            if (Input.GetKeyDown(KeyCode.Z))
            {
                currentMisile = Instantiate(Missile, new Vector3(pos.x, pos.y - 1.0f, pos.z - 1.0f), Quaternion.AngleAxis(270, Vector3.up));
            }
        }

        if( currentMisile && currentMisile.missileAdvance == 0)
        {
            Destroy(currentMisile.gameObject);
            currentMisile = null;
        }
        //Debug.Log(currentMisile);

        Vector3 v = new Vector3(pos.x, pos.y, pos.z);
        v.Normalize();

        transform.position = new Vector3(pos.x, pos.y, pos.z);
        transform.position.Normalize();




       // 速度に正規化したベクトルを代入
       //rb.velocity = transform.position.normalized;
    }

    
}

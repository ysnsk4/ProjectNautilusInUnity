using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    //Rigidbody rb;
    // Start is called before the first frame update

    public MissileMoveScript Missile; //オリジナルのオブジェクト
    private MissileMoveScript currentMisile;

    void Start()
    {
        //rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        // 入力を取得
        //var _h = Input.GetAxis("Horizontal");
        //var _v = Input.GetAxis("Vertical");

        Vector3 pos = transform.position;
        //Quaternion rot = transform.Rotate;

        if (Input.GetKey(KeyCode.RightArrow) || Input.GetKey(KeyCode.D))
        {
            pos.x += 0.05f;
        }

        //if (Input.GetKey(KeyCode.LeftArrow) || Input.GetKey(KeyCode.D))
        //{
        //    rot.x += 0.05f;
        //}

        if (Input.GetKey(KeyCode.LeftArrow) || Input.GetKey(KeyCode.A))
        {
            pos.x -= 0.05f;
        }

        //if (Input.GetKey(KeyCode.LeftArrow) || Input.GetKey(KeyCode.A))
        //{
        //    rot.x -= 0.05f;
        //}

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
                //InstantiatePrefab();
                currentMisile = Instantiate(Missile, new Vector3(pos.x, pos.y - 1.0f, pos.z - 1.0f), Quaternion.AngleAxis(270, Vector3.up));
            }
        }

        if( currentMisile && currentMisile.missileAdvance == 0)
        {
            Destroy(currentMisile.gameObject);
            currentMisile = null;
        }
        //Debug.Log(currentMisile);

        transform.position = new Vector3(pos.x, pos.y, pos.z);
        transform.position.Normalize();

        // 速度に正規化したベクトルを代入
        //rb.velocity = transform.position.normalized;
    }
}

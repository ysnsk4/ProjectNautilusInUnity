using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    //Rigidbody rb;

    // Start is called before the first frame update
    void Start()
    {
        //rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        // ���͂��擾
        //var _h = Input.GetAxis("Horizontal");
        //var _v = Input.GetAxis("Vertical");

        Vector3 pos = transform.position;

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
            pos.y += 0.01f;
        }
        if (Input.GetKey(KeyCode.LeftShift))
        {
            pos.y -= 0.01f;
        }

        transform.position = new Vector3(pos.x, pos.y, pos.z);
        transform.position.Normalize();

        // ���x�ɐ��K�������x�N�g������
        //rb.velocity = transform.position.normalized;
    }
}

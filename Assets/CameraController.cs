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
                // âÒì]é≤ÇÕÉèÅ[ÉãÉhç¿ïWÇÃYé≤
                transform.RotateAround(Player.transform.position, Vector3.up, mx*2);
            }
        }

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

        if (Input.GetMouseButton(0))
        {
            // Yï˚å¸Ç…àÍíËó à⁄ìÆÇµÇƒÇ¢ÇÍÇŒècâÒì]
            if (Mathf.Abs(my) > 0.1f)
            {
                    // âÒì]é≤ÇÕÉJÉÅÉâé©êgÇÃXé≤
                transform.RotateAround(Player.transform.position, transform.right, -my*2);
            }
        }

        //angle.y += Input.GetAxis("Mouse X");

        //if (angle.y <= primary_angle.y - 30f)
        //{
        //    angle.y = primary_angle.y - 30f;
        //}
        //if (angle.y >= primary_angle.y + 30f)
        //{
        //    angle.y = primary_angle.y + 30f;
        //}

        //this.gameObject.transform.localEulerAngles = angle;

        //if (Input.GetKey(KeyCode.L))
        //{
        //    pos.x += 0.01f;
        //}
        //if (Input.GetKey(KeyCode.J))
        //{
        //    pos.x -= 0.01f;
        //}
        //if (Input.GetKey(KeyCode.I))
        //{
        //    pos.z += 0.01f;
        //}
        //if (Input.GetKey(KeyCode.K))
        //{
        //    pos.z -= 0.01f;
        //}

        //transform.position = new Vector3(pos.x, pos.y, pos.z);
    }
}

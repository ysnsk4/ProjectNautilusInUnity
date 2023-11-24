using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MissileMoveScript : MonoBehaviour
{
    public GameObject Missile1; //オリジナルのオブジェクト
    int missileFlag = 1;
    int missileAdvance = 0;
    int missileDistance = 0;
    int missileCount = 0;

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

        //if (Input.GetKey(KeyCode.RightArrow) || Input.GetKey(KeyCode.D))
        //{
        //    pos.x += 0.05f;
        //}
        //if (Input.GetKey(KeyCode.LeftArrow) || Input.GetKey(KeyCode.A))
        //{
        //    pos.x -= 0.05f;
        //}
        //if (Input.GetKey(KeyCode.UpArrow) || Input.GetKey(KeyCode.W))
        //{
        //    pos.z += 0.05f;
        //}
        //if (Input.GetKey(KeyCode.DownArrow) || Input.GetKey(KeyCode.S))
        //{
        //    pos.z -= 0.05f;
        //}
        //if (Input.GetKey(KeyCode.Space))
        //{
        //    pos.y += 0.01f;
        //}
        //if (Input.GetKey(KeyCode.LeftShift))
        //{
        //    pos.y -= 0.01f;
        //}

        if (missileFlag == 0)
        {
            if (missileCount < 2)
            {
                //Instantiate(Missile1, new Vector3(-1.0f, 0.0f, 0.0f), Quaternion.identity);
                //GameObject Cube= Instantiate(CubePrefab, Random.Range(-5.0f, 5.0f), Random.Range(-5.0f, 5.0f), Quaternion.identity);
                missileCount += 1;
            }
            missileFlag = 1;
        }

        if (missileFlag == 1)
        {
            if (Input.GetKeyDown(KeyCode.Z))
            {
                missileAdvance = 1;
            }
            if (missileAdvance == 1)
            {
                pos.z += 0.01f;
                missileDistance += 1;
            }
            if (missileDistance >= 1000)
            {
                missileFlag = 0;
                missileAdvance = 0;
                missileDistance = 0;
                missileCount = 0;
                Destroy(this.gameObject);
            }
        }
       
        transform.position = new Vector3(pos.x, pos.y, pos.z);
        transform.position.Normalize();
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag== "breakable_rock")
        {
            other.GetComponent<BreakRock>().Damage();
        }
    }
}

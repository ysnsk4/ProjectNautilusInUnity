//using System.Collections;
//using System.Collections.Generic;
//using UnityEngine;
//using UnityEngine.SceneManagement; // UnityEngine.SceneManagemntの機能を使用

//public class ToSampleScene : MonoBehaviour
//{
//    int SceneNub = 0;
//    //0:タイトル,1:操作説明,2:プレイ画面,3:クリア画面

//    // 中に記述された処理が一定間隔で繰り返し実行される
//    void Update()
//    {
//        // もし入力したキーがSpaceキーならば、中の処理を実行する

//        //タイトル
//        if (SceneNub == 0)
//        {
//            if (Input.GetKeyDown(KeyCode.Space))
//            {
//                SceneManager.LoadScene("OperationScene");
//                SceneNub = 1;
//            }
//        }

//        //操作説明
//        if (SceneNub == 1)
//        {
//            if (Input.GetKeyDown(KeyCode.Space))
//            {
//                SceneManager.LoadScene("SampleScene");
//                SceneNub = 2;
//            }
//        }

//        //プレイ画面
//        if (SceneNub == 2)
//        {
//            if (Input.GetKeyDown(KeyCode.Space))
//            {
//                SceneManager.LoadScene("ClearScene");
//                SceneNub = 3;
//            }
//        }

//        //クリア画面
//        if (SceneNub == 3)
//        {
//            if (Input.GetKeyDown(KeyCode.Space))
//            {
//                SceneManager.LoadScene("TitleScene");
//                SceneNub = 0;
//            }
//        }
//    }
//}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement; // UnityEngine.SceneManagemntの機能を使用

public class ToOperationScene : MonoBehaviour
{
    // 中に記述された処理が一定間隔で繰り返し実行される
    void Update()
    {
        // もし入力したキーがSpaceキーならば、中の処理を実行する
        if (Input.GetKeyDown(KeyCode.Space))
        {
            // SampleSceneに切り替える
            SceneManager.LoadScene("OperationScene");
        }
    }
}
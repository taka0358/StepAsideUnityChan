using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemDestroyer : MonoBehaviour
{

    //Unityちゃんのオブジェクト
    private GameObject unitychan;


    // Start is called before the first frame update
    void Start()
    {
        //unityちゃんのオブジェクトを取得
        this.unitychan = GameObject.Find("unitychan");

    }

    // Update is called once per frame
    void Update()
    {
       
        //画面外に出たアイテムを直ちに破棄
        if (this.unitychan.transform.position.z-5 > this.transform.position.z)
        {
           

            //接触したコインのオブジェクトを破棄
            Destroy(gameObject);
        }
    }
}
       



    

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemDestroyer : MonoBehaviour
{

    //Unity�����̃I�u�W�F�N�g
    private GameObject unitychan;


    // Start is called before the first frame update
    void Start()
    {
        //unity�����̃I�u�W�F�N�g���擾
        this.unitychan = GameObject.Find("unitychan");

    }

    // Update is called once per frame
    void Update()
    {
       
        //��ʊO�ɏo���A�C�e���𒼂��ɔj��
        if (this.unitychan.transform.position.z-5 > this.transform.position.z)
        {
           

            //�ڐG�����R�C���̃I�u�W�F�N�g��j��
            Destroy(gameObject);
        }
    }
}
       



    

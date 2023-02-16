using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyCameraController : MonoBehaviour
{
    //Unity�����̃I�u�W�F�N�g
    private GameObject unitychan;
    //unity�����ƃJ�����̋���
    private float difference;

    // Start is called before the first frame update
    void Start()
    {
        //unity�����̃I�u�W�F�N�g���擾
        this.unitychan = GameObject.Find("unitychan");
        //unity�����ƃJ�����̈ʒu(z���W)�̍������߂�
        this.difference = unitychan.transform.position.z - this.transform.position.z;
    }

    // Update is called once per frame
    void Update()
    {
        //unity�����̈ʒu�ɍ��킹�ăJ�����̈ʒu���ړ�
        this.transform.position = new Vector3(0, this.transform.position.y, this.unitychan.transform.position.z - difference);
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawnerScript : MonoBehaviour
{
    public GameObject enemy;
    float timer;
    //�����͏����l���������ǁA�����Ȃ��ꍇ�͂O�ƔF�������
    void Start()
    {
      

    }

    // Update is called once per frame
    void Update(){
        timer += Time.deltaTime;
        //deltatime�͉��Z���Ă���

        if (timer > 2)
        {   //Instantiate(����,�ǂ���,�ǂ̌�����);
            Instantiate(enemy,this.transform.position + this.transform.right * Random.Range(-30.0f,30.0f),this.transform.rotation);
            timer = 0;

        }


        //�J�b�R���𐶐����Ă����
    }
}

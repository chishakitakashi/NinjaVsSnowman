using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawnerScript : MonoBehaviour
{
    public GameObject enemy;
    float timer;
    //いつもは初期値を書くけど、書かない場合は０と認識される
    void Start()
    {
      

    }

    // Update is called once per frame
    void Update(){
        timer += Time.deltaTime;
        //deltatimeは加算していく

        if (timer > 2)
        {   //Instantiate(何を,どこに,どの向きに);
            Instantiate(enemy,this.transform.position + this.transform.right * Random.Range(-30.0f,30.0f),this.transform.rotation);
            timer = 0;

        }


        //カッコ内を生成してくれる
    }
}

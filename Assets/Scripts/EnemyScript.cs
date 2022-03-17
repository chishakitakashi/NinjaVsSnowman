using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyScript : MonoBehaviour
{
    float speed = 15.0f;

    private Vector3 pos;


    // Start is called before the first frame update
    void Start()
    {
        Destroy(this.gameObject, 20.0f);
    }

    // Update is called once per frame
    void Update()
    {
        
        //this.transform.position += new Vector3(0, 0, speed * Time.deltaTime);
        this.transform.position += this.transform.forward * speed * Time.deltaTime;

        pos = transform.position;
        pos.y = Mathf.Clamp(pos.y, 0, 0);
        transform.position = pos;

    }

    void OnCollisionEnter(Collision col)
    {


        if (col.gameObject.tag == "shuriken")
        {
            Destroy(this.gameObject);
        }


    }
}

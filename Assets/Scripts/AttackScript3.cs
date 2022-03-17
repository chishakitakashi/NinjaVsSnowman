using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AttackScript3 : MonoBehaviour
{
    float speed = 50.0f;

    // Start is called before the first frame update
    void Start()
    {
        Destroy(this.gameObject, 5.0f);
    }

    // Update is called once per frame
    void Update()
    {
        this.transform.position += this.transform.forward * speed * Time.deltaTime;
    }

    void OnCollisionEnter(Collision col)
    {


        if (col.gameObject.tag == "shuriken")
        {
            Destroy(this.gameObject);
        }


    }
}

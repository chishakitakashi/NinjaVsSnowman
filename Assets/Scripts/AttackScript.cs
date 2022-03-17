using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AttackScript : MonoBehaviour
{
    float speed = 100.0f;
    float place = 1.0f;
    private Vector3 pos;

    // Start is called before the first frame update
    void Start()
    {
        this.transform.position += new Vector3(0, place, 0);
        Destroy(this.gameObject, 5.0f);
    }

    // Update is called once per frame
    void Update()
    {
        this.transform.position += this.transform.forward * speed * Time.deltaTime;
        pos = transform.position;
        pos.y = Mathf.Clamp(pos.y, 1, 1);
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

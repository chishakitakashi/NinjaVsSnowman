using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class ShurikenScript : MonoBehaviour
{
    float speed = 30.0f;
    float place = 0.1f;
    int count;
    //public Text countText;
    GameObject scoreObject;


    // Start is called before the first frame update
    void Start()
    {
        this.transform.position += new Vector3(0, 0, place);
        Destroy(this.gameObject, 5.0f);
    }

    // Update is called once per frame
    void Update()
    {
        this.transform.position += this.transform.forward * speed * Time.deltaTime;  
    }

    void OnCollisionEnter(Collision col)
    {
       

        if (col.gameObject.tag == "Attack")
        {

            Destroy(this.gameObject);
        }
        if (col.gameObject.tag == "Enemy")
        {
            //this.gameObject.GetComponent<AudioSource>().Play();
            GameObject.Find("Canvas").GetComponent<GameManagerScript>().AddScore();
            Destroy(this.gameObject);
        }
    }
}

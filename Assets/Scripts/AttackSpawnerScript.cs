using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AttackSpawnerScript : MonoBehaviour
{
    public GameObject attack;
    float timer;
    int place = -10;

    // Start is called before the first frame update
    void Start()
    {
        this.transform.position += new Vector3(0, 0, place);
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;
        //deltatimeは加算していく

        if (timer > 1)
        {   //Instantiate(何を,どこに,どの向きに);
            Instantiate(attack, this.transform.position, this.transform.rotation);
            timer = 0;

        }
    }
}

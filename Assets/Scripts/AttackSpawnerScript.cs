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
        //deltatime‚Í‰ÁŽZ‚µ‚Ä‚¢‚­

        if (timer > 1)
        {   //Instantiate(‰½‚ð,‚Ç‚±‚É,‚Ç‚ÌŒü‚«‚É);
            Instantiate(attack, this.transform.position, this.transform.rotation);
            timer = 0;

        }
    }
}

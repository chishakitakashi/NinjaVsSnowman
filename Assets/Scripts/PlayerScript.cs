using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class PlayerScript : MonoBehaviour
{
    public GameObject shuriken;
    float timer;
    int count;


    public FloatingJoystick inputMove; //左画面JoyStick
    float moveSpeed = 10.0f; //移動速度


   private Vector3 pos;
        void Start(){
       

    }

    void Update(){
        this.transform.position += this.transform.right * inputMove.Horizontal * moveSpeed * Time.deltaTime;


        pos = transform.position;
        pos.x = Mathf.Clamp(pos.x, -13, 13);
        transform.position = pos;
    }

 
        public void Shoot()
    {
            Instantiate(shuriken, this.transform.position, this.transform.rotation);
    }

//当たり判定を検知したときに処理
//collision colはcollisionが型でcolが変数。今回はcolに衝突したモノの情報が入っている
void OnCollisionEnter(Collision col)
    {
       

        if (col.gameObject.tag == "Enemy")
        {
            Destroy(this.gameObject);

            PlayerPrefs.SetInt("Score", count);
            GameObject.Find("Canvas").GetComponent<GameManagerScript>().Save();

            SceneManager.LoadScene("GameOverScene");
        }

        if (col.gameObject.tag == "Attack")
        {
            Destroy(this.gameObject);

            PlayerPrefs.SetInt("Score", count);
            GameObject.Find("Canvas").GetComponent<GameManagerScript>().Save();

            SceneManager.LoadScene("GameOverScene");
        }

    }
}

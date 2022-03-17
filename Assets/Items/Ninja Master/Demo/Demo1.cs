using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


public class Demo1 : MonoBehaviour {

	private Animator animator = null;

	public GameObject shuriken;
	float timer;


	private Vector3 pos;

	public FloatingJoystick inputMove; //左画面JoyStick
	float moveSpeed = 10.0f; //移動速度

	void Start () {
		animator = GetComponent<Animator>();
	}

	void Update()
	{
		animator.SetBool("Run", true);
		this.transform.position += this.transform.right * inputMove.Horizontal * moveSpeed * Time.deltaTime;


		pos = transform.position;
		pos.x = Mathf.Clamp(pos.x, -13, 13);
		transform.position = pos;
	}

	public void Shoot()
	{

		//animator.SetBool("GetAir", true);
		//Instantiate(shuriken, this.transform.position, this.transform.rotation);
	
	}

	void OnCollisionEnter(Collision col)
	{
		if (col.gameObject.tag == "wall")
		{
			Debug.Log("あたったよ");
		}

		if (col.gameObject.tag == "Enemy")
		{
			Destroy(this.gameObject);

			SceneManager.LoadScene("GameOverScene");
		}

		if (col.gameObject.tag == "Attack")
		{
			Destroy(this.gameObject);

			//PlayerPrefs.SetInt("score", count);
			GameObject.Find("Canvas").GetComponent<GameManagerScript>().Save();

			SceneManager.LoadScene("GameOverScene");
		}

	}

	
}

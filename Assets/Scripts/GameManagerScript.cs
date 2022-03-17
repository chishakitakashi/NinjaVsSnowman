using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManagerScript : MonoBehaviour
{
	int score = 0;
	public GameObject scoreText;

	

	public void AddScore()
	{
		this.score += 5;
	}
	//Canvas��GameManagerScripts���A�^�b�`���Ă���B����������5�_���Z�̃n�Y�����A10�_up���Ă���B�Ȃ����H2�����ɋʂ��o�Ă�BGameManagerScripts��2�����Ă��āAAddScore��2��Ăяo����Ă���H

	void Start()
	{
		this.scoreText = GameObject.Find("Score");

		
	}

	void Update()
	{
		scoreText.GetComponent<Text>().text = "Score:" + score.ToString("D4");
	}

	public void Save()
	{
		PlayerPrefs.SetInt("Score", score);
	}


}

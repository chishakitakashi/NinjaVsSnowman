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
	//CanvasにGameManagerScriptsをアタッチしている。当たったら5点加算のハズだが、10点upしている。なぜだ？2個同時に玉が出てる。GameManagerScriptsが2つつけられていて、AddScoreが2回呼び出されている？

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

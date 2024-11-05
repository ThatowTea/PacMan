using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class scorer : MonoBehaviour {

	// Use this for initialization
	private int score;
	public Text txtScore;

	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		txtScore.text = "Score: " + score;
	}
	public void AddScore(int toAdd)
	{
		score += toAdd;
		PlayerPrefs.SetInt ("Score", score);
		if(score == 4)
		{
			SceneManager.LoadScene (1);
		}
	}

}

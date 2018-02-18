using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClickIncrease : MonoBehaviour {

	public UnityEngine.UI.Text ScoreDisplay;
	public int score = 0;
	public int perClick = 1;


	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
		ScoreDisplay.text = "Score: " + score;
	}

	public void Clicked() {
		score += perClick;

	}

}

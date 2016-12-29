using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class UIController : MonoBehaviour {

	private float timeLeft = 300f;
	public Text timeLeftText;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		countDown ();
	}

	void countDown(){
		timeLeft -= Time.deltaTime;
		timeLeftText.text = "TIME: " + Mathf.Round(timeLeft);
//		if(timeLeft < 0)
//		{
//			Application.LoadLevel("gameOver");
//		}
	}
}

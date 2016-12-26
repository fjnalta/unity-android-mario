using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class PlayerController : MonoBehaviour {

	public int lives;
	public int health;

	void Start() {
		lives = 3;
		health = 1;
	}

	public void takeDamage(){
		if (lives > 1) {
			if (health > 1) {
				health--;
				Debug.Log ("new Health = " + health);
			} else {
				lives--;
				health = 3;
				Debug.Log ("new Lives = " + lives + " , new Health = 3");
			}	
		} else {
			gameOver ();
		}
	}

	void gameOver(){
		Debug.Log ("Game Over");
		SceneManager.LoadScene ("Menu");
	}

}

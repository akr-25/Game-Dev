using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour {

	public Transform player;
	public Text scoreText;
	public PlayerCollision life;
	
	// Update is called once per frame
	void Update () {
		int scorecard =1008-(int) player.position.z;
		scoreText.text ="Score:    " + scorecard.ToString("0") + "       Remaining life:    " + life.life.ToString("0");
	}
}

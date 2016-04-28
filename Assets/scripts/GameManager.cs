using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour {

	public GameObject ball;
	public Text countdown;
	public float time;
	private GameObject player;

	// Use this for initialization
	void Start () {
		//player = (GameObject) Instantiate(ball, new Vector3(0, 1.5f, 0), Quaternion.identity);
		countdown.text = "30:00";
	}
	
	// Update is called once per frame
	void Update () {
		

		getTimeLeft ();


		if (ball.transform.position.y < -2) {
			SceneManager.LoadScene (SceneManager.GetActiveScene().name);
		}
	}

	void getTimeLeft() {
		time -= Time.deltaTime;
		countdown.text = ""+ Mathf.Round(time * 100f) / 100f;

		if (time < 10f) {
			countdown.color = Color.red;
		}

		if (time <= 0) {
			SceneManager.LoadScene (SceneManager.GetActiveScene ().name);
		}
	}
}

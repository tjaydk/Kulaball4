using UnityEngine;
using System.Collections;

public class script : MonoBehaviour {
	public GameObject ball;
	public GameObject system;



	//Advantages 
	public bool ballSpeedFaster = false;
	public bool ballJumpHigher = false;
	public bool scaledLarger = false;

	//Disadvantages
	public bool scaledSmaller = false;
	public bool ballJumpLower = false;
	public bool ballSpeedSlower = false;

	private bool isActive = false;
	private int interval = 1;
	private float nextTime = 0;

	// Use this for initialization
	void Start () {

	}

	void Update(){
	}

	void OnTriggerEnter (Collider col)
	{

		/* DESTROY RIGID BODY AND PARTICLE SYSTEM TO REMOVE THEM FROM GAME */
		Destroy (system.GetComponent<BoxCollider>());
		Destroy (system.GetComponent<ParticleSystem>());


		if (col.gameObject.tag == "Player") {
			if (ballJumpHigher == true) {
				ball.GetComponent<Ball> ().m_JumpPower = 10;
			}if (ballJumpLower == true) {
				ball.GetComponent<Ball>().m_JumpPower = 0.2f;
			}if (ballSpeedFaster == true) {
				ball.GetComponent<Ball> ().m_MovePower = 20;
			}if (scaledLarger == true) {
				ball.transform.localScale += new Vector3 (2, 2, 2);
			} if (scaledSmaller == true) {
				ball.transform.localScale -= new Vector3 (0.5f, 0.5f, 0.5f);
			}if (ballSpeedSlower == true) {
				ball.GetComponent<Ball> ().m_MovePower = 0;
				ball.GetComponent<Ball> ().m_MaxAngularVelocity = 2;
			};
			isActive = true;
			InvokeRepeating ("randomMethod", 0, 1.0f);
		}
	}

	void randomMethod(){

		if (nextTime != 5 && isActive == true) {
			nextTime += interval;
		} else if (nextTime == 5 && isActive == true) {
			ball.GetComponent<Ball>().m_JumpPower = 1;
			ball.GetComponent<Ball>().m_MovePower = 3;
			if (scaledLarger == true) {
				ball.transform.localScale -= new Vector3 (2, 2, 2);
			}
			if (scaledSmaller) {
				ball.transform.localScale += new Vector3 (0.5f, 0.5f, 0.5f);
			}
			isActive = false;
			CancelInvoke ();

			/* DESTROY SYSTEM WHEN TIMER IS OVER */
			Destroy (system);
		} else {
			Debug.Log ("Error");
		}
	}
}
using System;
using UnityEngine;
using System.Collections;

public class PlaygroundScript : MonoBehaviour {

	private GameObject target;

	// Use this for initialization
	void Start () {
		target = GameObject.FindGameObjectWithTag ("Player");
		target.GetComponent<Ball> ().m_MovePower = 10f;
	}
	
	// Update is called once per frame
	void Update () {
	}
}

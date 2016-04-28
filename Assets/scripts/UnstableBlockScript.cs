﻿using UnityEngine;
using System.Collections;

public class UnstableBlockSrcipt : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnTriggerEnter(Collision col) {
		if (col.gameObject.name == "RollerBall") {
			StartCoroutine (destroyBlock());
		}
	}

	IEnumerator destroyBlock() {
		yield return new WaitForSeconds (0.5f);
		this.gameObject.AddComponent<Rigidbody>().useGravity = true;
		Destroy (this.gameObject, 3f);
	}

}

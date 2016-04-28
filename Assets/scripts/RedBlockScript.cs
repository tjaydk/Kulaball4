using UnityEngine;
using System.Collections;

public class RedBlockScript : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnTriggerEnter(Collision col){
		if (col.gameObject.name == "RollerBall") {
			this.gameObject.AddComponent<RigidBody>().useGravity = true;
			Destroy (this.gameObject, 3f);
		}
	}
}

using UnityEngine;
using System.Collections;

public class OrangeScript : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	IEnumerator  Destroy() {
		// Destroy(this.gameObject, 0.5f);
		yield return new WaitForSeconds(0.5f);
		this.gameObject.AddComponent<Rigidbody>().useGravity = true;
		Destroy (this.gameObject, 3);

	}

	void OnCollisionEnter(Collision col) {
		if (col.gameObject.name == "RollerBall") {
			StartCoroutine (Destroy ());
		}
	}
}

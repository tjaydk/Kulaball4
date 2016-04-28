using UnityEngine;
using System.Collections;

public class UnstableBlockSrcipt : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnCollisionEnter(Collision col) {
		if (col.gameObject.name == "RollerBall") {
			StartCoroutine (destroyBlock());
		}
	}

	IEnumerator  destroyBlock() {
		// Destroy(this.gameObject, 0.5f);
		yield return new WaitForSeconds(0.5f);
		this.gameObject.AddComponent<Rigidbody>().useGravity = true;
		Destroy (this.gameObject, 3);

	}

}

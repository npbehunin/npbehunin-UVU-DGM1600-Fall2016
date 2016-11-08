using UnityEngine;
using System.Collections;

public class Destroy : MonoBehaviour {
	public float countDown;
	public GameObject explosion;

	void OnCollisionEnter(Collision collision) {
		if(collision.gameObject.name == "Terrain"){
			Instantiate(explosion,transform.position,transform.rotation);
			Destroy (gameObject);
		}
	}

	void Update() {
		Destroy (gameObject, countDown);
	}
}

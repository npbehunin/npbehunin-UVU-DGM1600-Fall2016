using UnityEngine;
using System.Collections;

public class Destroy_Crate : MonoBehaviour {
	public GameObject debris;

	// Update is called once per frame
	void OnCollisionEnter(Collision collision){
	if(collision.gameObject.tag == "Projectile") {
		Instantiate(debris, transform.position, transform.rotation);
		Destroy (gameObject);
		}
	}
	void Update () {
	}
}

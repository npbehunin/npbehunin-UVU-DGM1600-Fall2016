using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class tankMovement : MonoBehaviour {
	private int count;

	public float moveSpeed;
	public float turnSpeed;
	public Text countText;

	// Use this for initialization
	void Start () {
		count = 0;
		SetCountText ();
	}
	
	// Update is called once per frame
	void Update () {
		// Moves forwards, backwards, and rotates left and right
		var x = Input.GetAxis("Horizontal") * Time.deltaTime * turnSpeed;
		var z = Input.GetAxis("Vertical") * Time.deltaTime * moveSpeed;

		transform.Rotate(0, x, 0);
		transform.Translate(0, 0, z);
	}
	// Collision detect with coin and set coin as inactive.
  	void OnTriggerEnter(Collider other) 
    {
        if (other.gameObject.CompareTag ("Coin"))
        {
            other.gameObject.SetActive (false);
			count = count + 1;
			SetCountText ();
        }
    }
	void SetCountText () {
			countText.text = "Count: " + count.ToString ();
	}
}


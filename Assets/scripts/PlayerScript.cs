using UnityEngine;
using System.Collections;

public class PlayerScript : MonoBehaviour {

	public float speed;
	private int count;
	public GUIText countText;
	void Start(){
		count = 0;
		countText.text = "Count: " + count.ToString ();
	}

	void FixedUpdate(){
		float moveHorizontal = Input.GetAxis ("Horizontal");
		float moveVertical = Input.GetAxis ("Vertical");

		Vector3 movement = new Vector3 (moveHorizontal, 0, moveVertical);

		rigidbody.AddForce (movement * speed*Time.deltaTime);
	}

	void OnTriggerEnter(Collider other) {
		if (other.gameObject.tag == "Puckup") {
			other.gameObject.SetActive (false);
			count++;
			countText.text = "Count: " + count.ToString ();
				}
	}
}
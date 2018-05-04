using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Force : MonoBehaviour {

	public float thrust=10;
	public Rigidbody2D rb;

	void Start()
	{
		rb = GetComponent<Rigidbody2D>();
	}

	void FixedUpdate()
	{
		Debug.Log ("F");
		if (Input.GetKeyDown(KeyCode.RightArrow)) {
			rb.AddForce (new Vector3 (25, 0, 0) * thrust);
		}
		Debug.Log ("F");
		if (Input.GetKeyDown(KeyCode.LeftArrow)) {
			rb.AddForce (new Vector3 (-25, 0, 0) * thrust);
		}
		Debug.Log ("F");
		if (Input.GetKeyDown(KeyCode.UpArrow)) {
			rb.AddForce (new Vector3 (0, 20, 0) * thrust);
		}
		Debug.Log ("F");
		if (Input.GetKeyDown(KeyCode.DownArrow)) {
			transform.position = Vector3.zero;
		}
	}

}


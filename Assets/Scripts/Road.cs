using UnityEngine;
using System.Collections;

public class Road : MonoBehaviour {

	private float speed = -3f;

	private Rigidbody2D myBody;

	void Awake () {
		myBody = GetComponent<Rigidbody2D> ();
	}

	void Update () {
		myBody.velocity = new Vector2 (0f, speed);
	}

	void OnTriggerEnter2D(Collider2D other) {
		//Debug.Log(other.gameObject);

		if (other.gameObject.tag == "Repeater") {
			//Debug.Break();
			transform.position = new Vector3 (-1.82f, 10.24f, 0f);
		}
	}

}

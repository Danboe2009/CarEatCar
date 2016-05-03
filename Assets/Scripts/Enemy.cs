using UnityEngine;
using System.Collections;

public class Enemy : MonoBehaviour {

	private float speed = -3f;

	private Rigidbody myBody;

	void Awake () {
		myBody = GetComponent<Rigidbody> ();
		resetPosition ();
	}

	void Update () {
		myBody.velocity = new Vector2 (0f, speed);

		if (transform.position.y < -5) {
			resetPosition ();
		}
	}

	void resetPosition(){
		int rand = Random.Range(0,3);
		switch (rand) {
		case 0:
			transform.position = new Vector2 (-1.77f, 5f);
			break;
		case 1:
			transform.position = new Vector2 (-0.59f, 5f);
			break;
		case 2:
			transform.position = new Vector2 (0.55f, 5f);
			break;
		case 3:
			transform.position = new Vector2 (1.71f, 5f);
			break;
		default:
			break;
		}
	}
}

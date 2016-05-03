using UnityEngine;
using System.Collections;

public class Buttons : MonoBehaviour {

	public Car car;
	void Start () {
	
	}
	
	void Update () {
	 	
	}

	public void LeftBut(){
		Debug.Log (car.xPos);
		switch (car.xPos) {
		case 171:
			car.moveTowards (0.55f);
			break;
		case 55:
			car.moveTowards (-0.59f);
			break;
		case -58:
			car.moveTowards (-1.77f);
			break;
		default:
			break;
		}
	}

	public void RightBut(){
		Debug.Log (car.xPos);
		switch (car.xPos) {
		case -176:
			car.moveTowards (-0.59f);
			break;
		case -58:
			car.moveTowards (0.55f);
			break;
		case 55:
			car.moveTowards (1.71f);
			break;
		default:
			break;
		}
	}
}

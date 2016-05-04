using UnityEngine;
using System.Collections;

public class EnemySystem : MonoBehaviour {

	public GameObject[] micro;
	public int microNum;

	// Use this for initialization
	void Start () {
		StartCoroutine (fillScreen ());
	}
	
	// Update is called once per frame
	void Update () {
		if (GameObject.FindGameObjectsWithTag ("Micro").Length == 0) {
			StartCoroutine (fillScreen ());
		}
		
	}

	IEnumerator fillScreen(){
		while (GameObject.FindGameObjectsWithTag ("Micro").Length < microNum) {
			int rand = Random.Range(0,micro.Length);
			//Debug.Log (rand);
			Instantiate (micro [rand]);
			yield return new WaitForSeconds (3);
		}
	}
}

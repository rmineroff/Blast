using UnityEngine;
using System.Collections;

public class destroy : MonoBehaviour {


	float timeLeft = 3f;

	void Start(){
		
	}

	void OnTriggerEnter (Collider col){
		if (col.gameObject.tag == "Enemy") {
			col.isTrigger = false;


			if (timeLeft >= 0) {
				timeLeft -= Time.deltaTime;
			} else {
				col.isTrigger = true;
			}
				




			Debug.Log ("Hit enemy");
			Destroy (gameObject);
			//StartCoroutine(onHit.hit());
			//glass.Play ();
		}
	}

	//void Update(){
	//	if
	//}


		

}

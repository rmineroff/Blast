using UnityEngine;
using System.Collections;

public class attack2 : MonoBehaviour {
	public Rigidbody cubePrefab;
	public Transform shipTip1;
	public bool allowfire = true;




	// Update is called once per frame
	void Update () {
		if (Input.GetButton("P2Attack") && allowfire == true) 
			StartCoroutine (Fire ());



		//Destroy (wandTip, 5);//Destroy the game object in 5 seconds.




	}
	public IEnumerator Fire() {
		allowfire = false;
	
		Rigidbody rocketInstance;
		rocketInstance = Instantiate (cubePrefab, shipTip1.position, shipTip1.rotation) as Rigidbody;
		rocketInstance.AddForce (shipTip1.up * 2000);
		yield return new WaitForSeconds(0.5f);
		allowfire = true;
	}
}

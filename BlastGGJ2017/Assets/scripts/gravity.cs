using UnityEngine;
using System.Collections;

public class gravity : MonoBehaviour {
	private Rigidbody player;
	private Rigidbody sphere;
	Vector3 pull;
	// Use this for initialization
	void Start () {
		sphere = GetComponent<Rigidbody>();

	}
	void FixedUpdate(){
		pull = sphere.position - player.transform.position;
		pull = pull.normalized;
		float distance = Vector3.Distance(player.transform.position, sphere.transform.position);
		if (distance <= 25) {
			player.AddForce (pull * 16);
		}

		//col.gameObject.GetComponent<Rigidbody> ().AddForce (pull * 12);
	}

	// Update is called once per frame

	void OnTriggerStay (Collider col)
	{
		if (col.gameObject.tag == "Player") {	
			player = col.gameObject.GetComponent<Rigidbody> ();
			
		}
		if (col.gameObject.tag == "Enemy") {	
			player = col.gameObject.GetComponent<Rigidbody> ();
		}
	}
}
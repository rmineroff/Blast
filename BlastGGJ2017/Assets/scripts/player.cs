using UnityEngine;
using System.Collections;

public class player : MonoBehaviour {

	float t = 0f;
	bool inv = false;
	int count = 3;
	private GameObject full10;
	private SpriteRenderer render10;

	private GameObject full20;
	private SpriteRenderer render20;

	private GameObject full30;
	private SpriteRenderer render30;
	// Use this for initialization
	void Start () {
		full10 = GameObject.Find ("hH1");
		render10 = full10.GetComponent<SpriteRenderer> ();

		full20 = GameObject.Find ("hH2");
		render20 = full20.GetComponent<SpriteRenderer> ();

		full30 = GameObject.Find ("hH3");
		render30 = full30.GetComponent<SpriteRenderer> ();
	}

	// Update is called once per frame
	void Update () {
		if (inv) {
			t += Time.deltaTime;
			if (t >= 3f) {

				inv = false;
				print (inv);
			}
			print (t);
		}



	}

	void OnTriggerEnter(Collider col){
		
		if (!inv) {
			if (col.tag == "Bullet") {
				Destroy (col.gameObject);
				inv = true;
				print (inv);
				t = 0f;
				if (count == 1) {
					render30.enabled = false;
					print ("im out chief");
					count--;
					Application.LoadLevel ("enemyWins");
				}
				if (count == 2) {
					render20.enabled = false;
					print ("lost another");
					count--;
				}
				if (count == 3) {
					render10.enabled = false;
					print ("lost 1");
					print (count);
					count--;
				}


			}


		}
	}





}

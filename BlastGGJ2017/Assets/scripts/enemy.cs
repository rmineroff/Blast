using UnityEngine;
using System.Collections;

public class enemy : MonoBehaviour {
	float t = 0f;
	bool inv = false;
	int count = 3;
	private GameObject full1;
	private SpriteRenderer render1;

	private GameObject full2;
	private SpriteRenderer render2;

	private GameObject full3;
	private SpriteRenderer render3;
	// Use this for initialization
	void Start () {
		full1 = GameObject.Find ("eH1");
		render1 = full1.GetComponent<SpriteRenderer> ();

		full2 = GameObject.Find ("eH2");
		render2 = full2.GetComponent<SpriteRenderer> ();

		full3 = GameObject.Find ("eH3");
		render3 = full3.GetComponent<SpriteRenderer> ();
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
					render3.enabled = false;
					print ("im out chief");
					count--;
					Application.LoadLevel("heroWins");
				}
				if (count == 2) {
					render2.enabled = false;
					print("lost another");
					count--;
				}
				if (count == 3) {
					render1.enabled = false;
					print("lost 1");
					print (count);
					count--;
				}


			}


		}




	


	}
}

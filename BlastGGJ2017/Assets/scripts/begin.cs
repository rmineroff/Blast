using UnityEngine;
using System.Collections;

public class begin : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown ("space")) {
			print ("update");
			Application.LoadLevel ("movement");
		}
	}
}

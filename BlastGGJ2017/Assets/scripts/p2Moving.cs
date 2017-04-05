using UnityEngine;
using System.Collections;

public class p2Moving : MonoBehaviour {
	public Rigidbody rb;
	public float value;
	//Vector3 up = new Vector3(1,0,0);
	// Use this for initialization
	void Start () {
		rb = GetComponent<Rigidbody>();
	}

	// Update is called once per frame
	void Update () {

	}

	void FixedUpdate(){

		//ROCKET BURST
		if (Input.GetButton("P2boost")){
			print("space key was pressed");
			rb.AddForce (-transform.right * 2, ForceMode.Impulse);
			//rb.useGravity = true;

		}

		//TRANSLATE
		var horzL = Input.GetAxis("P2X360_LstickX");
		var vertL = Input.GetAxis("P2X360_LstickY");
		Vector3 movement = new Vector3 (horzL, -vertL, 0);
		rb.AddForce (movement * 16f);
		if (rb.velocity.magnitude >= 30f)
			rb.AddForce (rb.velocity.normalized * -20);


		//ROTATE
		if (Input.GetAxis("P2X360_RstickX") > 0){
			var horz = Input.GetAxis ("P2X360_RstickX");
			//Debug.Log (horz);
			print("ITS ROTATING");
			transform.Rotate(-Vector3.forward * 10);

		}
		if (Input.GetAxis("P2X360_RstickX") < 0){
			var horz = Input.GetAxis ("P2X360_RstickX");
			//Debug.Log (horz);
			print("ITS ROTATING2");
			transform.Rotate(Vector3.forward * 10);

		}

		if (this.transform.position.x < -110)
			this.transform.position = new Vector3(110f, this.transform.position.y, this.transform.position.z);

		if (this.transform.position.x > 110)
			this.transform.position = new Vector3(-110f, this.transform.position.y, this.transform.position.z);

		if (this.transform.position.y < -55)
			this.transform.position = new Vector3(this.transform.position.x, 55, this.transform.position.z);

		if (this.transform.position.y > 55)
			this.transform.position = new Vector3(this.transform.position.x, -55, this.transform.position.z);




	}
}

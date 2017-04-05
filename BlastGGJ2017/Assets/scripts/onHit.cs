using UnityEngine;
using System.Collections;

public class onHit : MonoBehaviour {

	public static BoxCollider boxCol;

	void Start(){
		//boxCol.GetComponent<Renderer> ().enabled = true;
	}

	/*public static IEnumerator hit(){
		GameObject ship = boxCol.GetComponent<Renderer>();
		ship.enabled = false;
		//ship =boxCol.GetComponent<Renderer> ().enabled = false;
		yield return new WaitForSeconds(2f);
		print ("waiting");
		ship.enabled = true;


	}
	*/
}






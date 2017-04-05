using UnityEngine;
using System.Collections;

public class follow1 : MonoBehaviour {
	public Rigidbody player, player1a, player1b, player1c, player1d, player1e, player1f, player1g, player1h, player1i; 
	public Vector3 offset;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		player1b.transform.position = new Vector3 ((player1a.position.x - 220), player1a.position.y, 0);
		player1c.transform.position = new Vector3 ((player1a.position.x + 220), player1a.position.y, 0);
		player1d.transform.position = new Vector3 (player1a.position.x, (player1a.position.y + 110), 0);
		player1e.transform.position = new Vector3 (player1a.position.x, (player1a.position.y - 110), 0);
		player1f.transform.position = new Vector3 ((player1a.position.x - 220), (player1a.position.y - 110), 0);
		player1g.transform.position = new Vector3 ((player1a.position.x - 220), (player1a.position.y + 110), 0);
		player1h.transform.position = new Vector3 ((player1a.position.x + 220), (player1a.position.y - 110), 0);
		player1i.transform.position = new Vector3 ((player1a.position.x + 220), (player1a.position.y + 110), 0);

		//if (player1a.transform.position.x < 120 && player1a.transform.position.x > -120 && player1a.transform.position.y > -55 && player1a.transform.position.y < 55)
			//player = player1a;
		/*if (player1b.transform.position.x < 120 && player1b.transform.position.x > -120 && player1b.transform.position.y > -55 && player1b.transform.position.y < 55)
			player = player1b;
		if (player1c.transform.position.x < 120 && player1c.transform.position.x > -120 && player1c.transform.position.y > -55 && player1c.transform.position.y < 55)
			player = player1c;
		if (player1d.transform.position.x < 120 && player1d.transform.position.x > -120 && player1d.transform.position.y > -55 && player1d.transform.position.y < 55)
			player = player1d;
		if (player1e.transform.position.x < 120 && player1e.transform.position.x > -120 && player1e.transform.position.y > -55 && player1e.transform.position.y < 55)
			player = player1e;
		if (player1f.transform.position.x < 120 && player1f.transform.position.x > -120 && player1f.transform.position.y > -55 && player1f.transform.position.y < 55)
			player = player1f;
		if (player1g.transform.position.x < 120 && player1g.transform.position.x > -120 && player1g.transform.position.y > -55 && player1g.transform.position.y < 55)
			player = player1g;
		if (player1h.transform.position.x < 120 && player1h.transform.position.x > -120 && player1h.transform.position.y > -55 && player1h.transform.position.y < 55)
			player = player1h;
		if (player1i.transform.position.x < 120 && player1i.transform.position.x > -120 && player1i.transform.position.y > -55 && player1i.transform.position.y < 55)
			player = player1i;*/
		
		
		transform.position = new Vector3 (player.position.x + offset.x, player.position.y + offset.y, -25f);
	}
}

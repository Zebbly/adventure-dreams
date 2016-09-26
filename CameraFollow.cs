using UnityEngine;
using System.Collections;

public class CameraFollow : MonoBehaviour {
	public GameObject lowbound;     //empty game object positioned at the bottom of the map	
	public GameObject highbound;    //empty game object positioned at the   top  of the map
	public GameObject rightbound;   //empty game object positioned on the  right of the map
	public GameObject leftbound;   	//empty game object positioned on the  left  of the map
	public GameObject player;		//object of camera follow

	private float yadjusted;			//new camera vertical   position to keep within map edges
	private float xadjusted;			//newcamera horizontal position to keep within map edges

	void Start () {
		yadjusted = 0;
		xadjusted = 0;
	}

	void LateUpdate () {

		checkBoundy ();
		checkBoundx ();
		transform.position = new Vector3 (xadjusted, yadjusted, -10);
	}

	void checkBoundy () {
		if (player.transform.position.y + 1 >= highbound.transform.position.y) 
			yadjusted = 1;
		else if (player.transform.position.y - 1 <= lowbound.transform.position.y)
			yadjusted = -1;
		else
			yadjusted = player.transform.position.y;
	}

	void checkBoundx () {
		if (player.transform.position.x + 2.3 >= rightbound.transform.position.x)
			xadjusted = rightbound.transform.position.x - 2.3f;
		else if (player.transform.position.x - 2.3 <= leftbound.transform.position.x)
			xadjusted = leftbound.transform.position.x - -2.3f;
		else
			xadjusted = player.transform.position.x;
	}

}			
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerMovement : MonoBehaviour {


	GameGrid gamegrid; //Reference to gamegrid script
	Transform newPos;



	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		characterController();
	}



	//Insert Character gameobject in world
	//Also take empty boxes?
	public void characterController()
	{
		if (Input.GetKeyDown(KeyCode.A)) {


			transform.Translate (-1, 0, 0 * Time.deltaTime) ;
			Debug.Log ("You moved left");
			//transform.Translate = gamegrid.blockTiles[x + 1];
			//gamegrid.blockTiles [x - 1, y];




		}

		if (Input.GetKeyDown(KeyCode.D)) {

			transform.Translate (1, 0, 0 * Time.deltaTime);
		}

		if (Input.GetKeyDown(KeyCode.W)) {

			transform.Translate (0, 1, 0 * Time.deltaTime);
		}

		if (Input.GetKeyDown(KeyCode.S)) {

			transform.Translate (0, -1, 0 * Time.deltaTime);
		}



	}



	//Colliding with gameobjects


	void OnTriggerEnter(Collider collider)
	{
		if(collider.tag == ("Block"))
			{


			}

	}

	

}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameGrid : MonoBehaviour {

	//Declared Variables

	public static GameGrid instance;
	public GameObject TilePrefab;

	public  GameObject player;
	public GameObject block;

	public Transform playerSpawner;
	public Transform newPos;



	//Create/Generate a Grid 
	public GameObject [,] blockTiles; //Reference to grid here which will be an

	//Map Size
	public Vector2 m_mapSize;

	//Outline range for each tile
	[Range(0,1)]
	public float m_outlinePercent;



	void Awake()
	{
		instance = this;
	}




	void Start () {

		createBlocks (0,0,0);
		Instantiate(player, playerSpawner);

		//Reference to the enum

		//Reference to the generateMap function
		generateMap ();

	}
	
	// Update is called once per frame
	void Update () {
		
	}



	//Enumerator here that will consist of 
	// Player, Block, Empty grid Spot, and etc

	public enum WorldObjects
	{
		PLAYER,
		EMPTYGRID,
		BLOCKS

	}






	//Switch Case Statement for conditions for the player
	//....Code....





	//public functions will go down here..
	//....Code....



	public void generateMap()
	{
		
		blockTiles = new GameObject[12,12];


		//This is for generating tiles on the "X" axis
		for (int x = 0; x < m_mapSize.x; x++) {


			//This is for generating tiles on the "Y" axis
			for (int y = 0; y < m_mapSize.y; y++) {

				Vector3 m_tilePosition = new Vector3 (-m_mapSize.x / 2 + 1.0f + x, 
					                         -m_mapSize.y / 2 + 1.0f + y,0);
			
			
				GameObject go = GameObject.Instantiate (TilePrefab, m_tilePosition,
					                Quaternion.Euler (Vector3.zero)) as GameObject;
			
				blockTiles [x, y] = go;
			
			

			}



		}
			

	}


	public void createBlocks(int x, int y,int z)
	{
		Instantiate (block, new Vector4 (x - 1, 0, -1.09f,0f), new Quaternion (0, 0, 0, 0));

	}



}

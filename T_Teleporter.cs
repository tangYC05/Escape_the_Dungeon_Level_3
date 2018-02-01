using UnityEngine;
using System.Collections;

//This script is use to 
//teleport player upon falling into a trap

//This plan had been call off because
//The features are already more than enought
//But I keep it for future usage

public class T_Teleporter : MonoBehaviour {

	public GameObject spawnPoint;
	public GameObject player;

	//When fall into a trap, teleport player
	void OnTriggerEnter(Collider coll)
	{
		player.transform.position = spawnPoint.transform.position;
	}
}

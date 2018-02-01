using UnityEngine;
using System.Collections;

//This script is used to check if the player did a objective check
public class T_TutorialCheck : MonoBehaviour {

	public GameObject BlockingWalls;
	public GameObject triggerBox;
	T_UIManager uiManager;

	void Start()
	{
		uiManager = FindObjectOfType<T_UIManager> ();
	}

	//If the player did a objective check, 
	//The next area is revealed
	void OnTriggerEnter(Collider col)
	{
		uiManager.the1stTime = false;
		Destroy (BlockingWalls);
		Destroy (triggerBox);
	}
}

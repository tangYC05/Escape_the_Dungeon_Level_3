using UnityEngine;
using System.Collections;

//This script is used to change scene upon collision trigger
public class T_ChangeSceneTrigger : MonoBehaviour {

	void OnTriggerEnter(Collider col)
	{
		T_SceneManager sceneManager = FindObjectOfType<T_SceneManager> ();
		sceneManager.nextLevel();
	}
}

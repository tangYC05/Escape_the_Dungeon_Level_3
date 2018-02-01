using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

//This script is used to manage the script
//And the cheat code
public class T_SceneManager : MonoBehaviour {

	int currentSceneIndex;

	private string[] cheatCode;
	private int index;

	void Start () 
	{
		//====================================
		//Cheat Code to restart game: lollipop
		cheatCode = new string[] {"l", "o", "l", "l", "i", "p", "o", "p"};
		index = 0;
		//====================================
	}

	void Update ()
	{
		//The cheat code checking
		if (Input.anyKeyDown) {
			if (Input.GetKeyDown (cheatCode [index])) {
				index++;
			} else {
				index = 0;    
			}
		}
		//If the inputs are all correct
		if (index == cheatCode.Length) {
			T_EventManager eventManager = FindObjectOfType<T_EventManager> ();
			eventManager.gemsLeft = 1;
		}
	}

	//Change Scene
	public void nextLevel()
	{
		SceneManager.LoadScene (4);
	}

}

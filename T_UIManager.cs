using UnityEngine;
using UnityEngine.UI;
using System.Collections;

//This script is used handle all UI
public class T_UIManager : MonoBehaviour {

	public Text countText;

	public Canvas MenuCanvas;
	public Canvas GameCanvas;
	public Canvas tutorialCanvas;

	public bool the1stTime = true;
	bool showUI = false;

	T_EventManager eventManager;

	void Start () {
		eventManager = FindObjectOfType<T_EventManager> ();
		the1stTime = true;
	}

	void Update () {
		countText.text = "Gems Remaining: " + eventManager.gemsLeft;

		//Show UI upon the Tab button is pressed
		if (Input.GetKeyDown (KeyCode.Tab)) 
		{
			showUI = !showUI;
		}

		if (showUI == false) {
			MenuCanvas.enabled = false;
			GameCanvas.enabled = true;
		} else if (showUI == true) {
			MenuCanvas.enabled = true;
			GameCanvas.enabled = false;
		}

		if (the1stTime == true) {
			tutorialCanvas.enabled = true;
			GameCanvas.enabled = false;
		} else if (the1stTime == false){
			tutorialCanvas.enabled = false;
		}
	}
}
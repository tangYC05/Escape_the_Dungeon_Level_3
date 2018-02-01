using UnityEngine;
using System.Collections;

//This script handles all the main events

public class T_EventManager : MonoBehaviour {

	public int gemsLeft;
	public GameObject finishingAudio;
	float lightIntensity = 3;
	bool actionDone = false;
	public GameObject spotlight1, spotlight2, spotlight3, spotlight4;

	// Use this for initialization
	void Start () {
		gemsLeft = 4;	
	}
	
	// Update is called once per frame
	void Update () 
	{
		//If all gems have collected, do the explosion sequence
		if (gemsLeft == 0) 
		{
			Light spot1 = spotlight1.GetComponent<Light> ();
			Light spot2 = spotlight2.GetComponent<Light> ();
			Light spot3 = spotlight3.GetComponent<Light> ();
			Light spot4 = spotlight4.GetComponent<Light> ();

			spot1.intensity += lightIntensity * Time.deltaTime/8;
			spot2.intensity += lightIntensity * Time.deltaTime/8;
			spot3.intensity += lightIntensity * Time.deltaTime/8;
			spot4.intensity += lightIntensity * Time.deltaTime/8;

			if (actionDone == false) 
			{
				AudioSource blowAudio = finishingAudio.GetComponent<AudioSource> ();
				blowAudio.Play ();
				spot1.intensity = 0;
				spot2.intensity = 0;
				spot3.intensity = 0;
				spot4.intensity = 0;
				Invoke ("destroyWall", 14);
				actionDone = true;
			}
		}
	}

	//Decrease the gems count
	public void DecreaseCount()
	{
		gemsLeft--;
	}

	//Update the gems count
	public int updateCount()
	{
		return gemsLeft;
	}

	//Explode the wall
	void destroyWall()
	{
		T_CollidingWall collWall = FindObjectOfType<T_CollidingWall> ();
		collWall.CollapsWall ();
	}
}

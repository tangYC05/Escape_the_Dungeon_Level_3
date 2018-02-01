using UnityEngine;
using System.Collections;

//This script is use for the altar to detect 
//whether the gem dropped into is the correct gem

public class T_AltarDetection : MonoBehaviour {

	public GameObject altarBlockage;
	public GameObject spotLight;
	public GameObject targetGem;
	public GameObject respawnPoint;
	public AudioSource correctGemsfx, wrongGemsfx;

	public string gemTag;

	void Start () {
		altarBlockage.SetActive (false);
	}
		
	void OnTriggerEnter(Collider col)
	{
		//if the gem is the correct gem, lights up and lock the altar
		if (col.tag == gemTag) {
			Light igniteGem = targetGem.GetComponent<Light> ();
			Light spotLightlamp = spotLight.GetComponent<Light> ();
			T_EventManager eventmanager = FindObjectOfType<T_EventManager> ();
			spotLightlamp.enabled = true;
			igniteGem.enabled = true;
			altarBlockage.SetActive (true);
			eventmanager.DecreaseCount ();
			correctGemsfx.Play ();
		} 
		//if wrong, respawn the gem out of the altar
		else 
		{
			col.transform.position = respawnPoint.transform.position;
			wrongGemsfx.Play ();
		}
	}
}

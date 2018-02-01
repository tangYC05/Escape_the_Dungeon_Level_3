using UnityEngine;
using System.Collections;


//This script is used to create falling blocks sound effect
public class T_RockFallingAudio : MonoBehaviour {
	
	void OnCollisionEnter(Collision collision)
	{
		AudioSource audio = GetComponent<AudioSource> ();
		audio.Play ();
	}
}

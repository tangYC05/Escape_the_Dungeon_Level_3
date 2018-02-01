using UnityEngine;
using System.Collections;

//This script is used to create a random sound generator
public class T_RandomAudio : MonoBehaviour {

	public AudioClip[] audioClips;
	AudioSource audioSourse;

	void Start () {
		audioSourse = GetComponent<AudioSource> ();
	}

	//For every random delay, call the random audio function
	void Update () 
	{
		float randomTimedelay = Random.Range (35, 50);
		Invoke ("randomAudio", randomTimedelay);
	}

	//Randomly pick an audio from the audio list(array)
	void randomAudio()
	{
		int randomSelected = Random.Range (0, audioClips.Length);
		audioSourse.clip = audioClips [randomSelected];
		audioSourse.volume = 0.8f;
		audioSourse.Play ();
		CancelInvoke(); //Prevent repeating invoke
	}
}

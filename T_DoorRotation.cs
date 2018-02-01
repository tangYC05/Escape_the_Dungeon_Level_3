using UnityEngine;
using System.Collections;

//This script is used to rotate the door

public class T_DoorRotation : MonoBehaviour {

	public int openAngle = 65;

	//Rotate the door on the local pivot and rotation
	public void RotateDoor(int openAngle)
	{
		transform.Rotate (Vector3.up, openAngle, Space.Self); 
	}

}

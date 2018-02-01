using UnityEngine;
using System.Collections;

//This script is used to set the camera movement(rotation)
//Put this script On Player and also player camera
//For Player, set mouse to X
//For Camera, set mouse to Y

public class T_Spin : MonoBehaviour {

	public float speed = 30.0f;
	float vertMin = -55;
	float vertMax = 55;

	float xRotation;

	public enum rotationAxis {MouseX, MouseY};

	public rotationAxis axes;
	
	//Rotate the camera
	void Update () {

		if (axes == rotationAxis.MouseX) {
			transform.Rotate (0, Input.GetAxis ("Mouse X") * speed * Time.deltaTime, 0);
		} else {

			xRotation -= Input.GetAxis ("Mouse Y") * speed * Time.deltaTime;
			xRotation = Mathf.Clamp (xRotation, vertMin, vertMax);
			transform.localEulerAngles = new Vector3 (xRotation, transform.localEulerAngles.y, 0);
		}
	}
}

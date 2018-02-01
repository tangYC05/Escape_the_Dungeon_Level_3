using UnityEngine;
using System.Collections;

//This script is used for the collectable glowing gems
public class T_GlowingGem : MonoBehaviour {

	public float speed = 100.0f;

	float xRotation, yRotation, zRotation;

	public enum rotationAxis {XAxis, YAxis, ZAxis};

	public rotationAxis axis;

	public GameObject onHand;
	
	//This script is use to set the rotation of the gems flexibly
	void Update () {

		if (axis == rotationAxis.XAxis) 
		{
			transform.Rotate (Time.deltaTime * speed, 0, 0,Space.World);
		}
		else if(axis == rotationAxis.YAxis) 
		{
			transform.Rotate (0, Time.deltaTime * speed ,0, Space.World);
		}
		else if(axis == rotationAxis.XAxis) 
		{
			transform.Rotate (0,0,Time.deltaTime * speed, Space.World);
		}
	}

	//When click and hold on the gems, put the gems in front of the player
	void OnMouseDown()
	{
		GetComponent<Rigidbody> ().useGravity = false;
		this.transform.position = onHand.transform.position;
		this.transform.parent = GameObject.FindObjectOfType<T_Spin> ().transform;
	}

	//When release, the gems will drop on the floor
	void OnMouseUp()
	{
		this.transform.parent = null;
		GetComponent<Rigidbody> ().useGravity = true;
	}
}

using UnityEngine;
using System.Collections;

//This script handles the explosion of the wall

public class T_CollidingWall : MonoBehaviour {

	Rigidbody rb;

	Component[] smallBlocks;

	public GameObject explosionCentre;

	//give all bricks a rigidbody
	void Start () {
		smallBlocks = GetComponentsInChildren<Rigidbody> ();
		foreach (Rigidbody rb in smallBlocks) 
		{
			//rb.constraints = RigidbodyConstraints.FreezeAll;
			rb.constraints = RigidbodyConstraints.None;
		}
	}

	//Explode the wall
	public void CollapsWall()
	{
		foreach (Rigidbody rb in smallBlocks) 
		{
			rb.constraints = RigidbodyConstraints.None;
			rb.AddExplosionForce (-1000, explosionCentre.transform.position, 500, 0.0f);
		}
	}
}

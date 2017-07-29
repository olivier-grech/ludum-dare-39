using UnityEngine;
using System.Collections;

[RequireComponent (typeof (Rigidbody2D))]
public class GravityBody : MonoBehaviour {

	public GravityAttractor attractor;
	private Transform myTransform;

	void Start () 
	{
		//GetComponent<Rigidbody2D>().useGravity = false;
		//GetComponent<Rigidbody2D>().constraints = RigidbodyConstraints2D.FreezeRotation;

		myTransform = transform;
	}

	void FixedUpdate () 
	{
		if (attractor != GameManager.p1Attraction)
		{
			attractor = GameManager.p1Attraction;
		}
		if (attractor)
			{
				attractor.Attract(myTransform);
			}
	}
}
using UnityEngine;
using System.Collections;

[RequireComponent (typeof (Rigidbody2D))]
public class GravityBody : MonoBehaviour {

	public GravityAttractor attractor;
	private Transform myTransform;

	private LevelManager m_LevelManager;
	void Start () 
	{
		//GetComponent<Rigidbody2D>().useGravity = false;
		//GetComponent<Rigidbody2D>().constraints = RigidbodyConstraints2D.FreezeRotation;
		m_LevelManager = LevelManager.instance;
		myTransform = transform;
	}

	void FixedUpdate () 
	{
		if (attractor != m_LevelManager.m_Player1Attraction)
		{
			attractor = m_LevelManager.m_Player1Attraction;
		}
		if (attractor)
			{
				attractor.Attract(myTransform);
			}
	}
}
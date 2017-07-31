using UnityEngine;
using System.Collections;

[RequireComponent (typeof (Rigidbody2D))]
public class GravityBody : MonoBehaviour {

	public GravityAttractor attractor;
	private Transform myTransform;

	private LevelManager m_LevelManager;

	private void Awake()
	{
	}

	void Start () 
	{
		//GetComponent<Rigidbody2D>().useGravity = false;
		//GetComponent<Rigidbody2D>().constraints = RigidbodyConstraints2D.FreezeRotation;
		m_LevelManager = LevelManager.instance;
		myTransform = transform;
		attractor = null;
	}

	void FixedUpdate () 
	{
	/*	if (attractor !=)
		{
			attractor = m_LevelManager.GetCurrentAttractor();
		}*/
		if (attractor)
			{
				attractor.Attract(myTransform);
			}
	}
}
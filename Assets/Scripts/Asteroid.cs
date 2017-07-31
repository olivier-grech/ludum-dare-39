using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Asteroid : MonoBehaviour
{
	public Rigidbody2D ThisRigidbody2D;
	public float xForce;
	public float yForce;
	
	// Use this for initialization
	private void Awake()
	{
		ThisRigidbody2D = GetComponent<Rigidbody2D>();
	}

	void Start () {
		ThisRigidbody2D.AddForce(new Vector2(xForce,yForce));
		Debug.Log("I'm here");
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}

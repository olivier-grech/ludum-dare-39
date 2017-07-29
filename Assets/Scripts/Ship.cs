using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using UnityEngine;

public class Ship : MonoBehaviour
{
	public float speed;
	public float angle;
	private Vector3 innertie;
	public Rigidbody rb;

	// Use this for initialization
	void Start()
	{
		rb = GetComponent<Rigidbody>();
		speed = 1.0f;
	}

	// Update is called once per frame
	void Update()
	{
		//Vector3 move = new Vector3(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"), 0);
		//transform.position += move * speed * Time.deltaTime;
		
		//transform.position += transform.position * speed * Time.deltaTime;
		ChangeAngle();
		ChangeSpeed();
	}

	private void FixedUpdate()
	{

	}

	public void ChangeSpeed()
	{
		speed = Input.GetAxis("Vertical");
		rb.AddForce(transform.up * speed * 10f);
	}

	public void ChangeAngle()
	{
		angle = -Input.GetAxis("Horizontal");
		rb.AddTorque(0,0, angle * 3f);
		//transform.Rotate(new Vector3(0,0,angle) * 10f);
	}
}

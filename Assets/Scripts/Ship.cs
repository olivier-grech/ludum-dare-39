using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using UnityEngine;

public class Ship : MonoBehaviour
{
	public float m_MoveSpeed;
	public float m_TurnSpeed;
	public float m_Angle;
	public float m_FuelConsumption;
	public Rigidbody2D m_Rigidbody2D;
	public GameObject m_FuelJaugeObject;
	public GameObject m_Booster;
	
	private Vector3 m_Inertia;
	private Jauge m_FuelJauge;
	private ParticleSystem m_BoosterParticleSystem;
	
	void Awake()
	{
		//m_FuelJauge = m_FuelJaugeObject.GetComponent<Jauge>();
		m_BoosterParticleSystem = m_Booster.GetComponent<ParticleSystem>();
	}

	// Use this for initialization
	void Start()
	{
		m_FuelJauge = Jauge.instance;
		m_Rigidbody2D = GetComponent<Rigidbody2D>();
		m_MoveSpeed = 3.0f;
		m_TurnSpeed = 0.5f;
	}

	// Update is called once per frame
	void Update()
	{
		ChangeAngle();
		ChangeSpeed();
	}

	public void ChangeSpeed()
	{
		if (m_FuelJauge.GetFuelAmount()>0)
		{
			float input = Input.GetAxis("Vertical");
			
			if (input > 0)
			{
				// Add force to move
				m_Rigidbody2D.AddForce(transform.up * input * m_MoveSpeed);
				
				// Emit particles
				
				
				// Remove fuel
				m_BoosterParticleSystem.Emit(1);
				m_FuelJauge.RemoveFuel(input * m_FuelConsumption);
			}
		}
	}

	public void ChangeAngle()
	{
		m_Angle = -Input.GetAxis("Horizontal");
		m_Rigidbody2D.AddTorque(m_Angle * m_TurnSpeed);
	}
}

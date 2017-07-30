using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using UnityEngine;

public class Jauge : MonoBehaviour
{
	public GameObject m_JaugeFill;
	// public GameObject m_Explosion;

	public static Jauge instance;
	
	private RectTransform m_JaugeFillTransform;
	private ParticleSystem m_ExplosionParticleSystem;
	private float m_FuelAmount;

	void Awake()
	{
		instance = this;
		m_JaugeFillTransform= m_JaugeFill.GetComponent<RectTransform>();
		// m_ExplosionParticleSystem = m_Explosion.GetComponent<ParticleSystem>();
	}

	// Use this for initialization
	void Start ()
	{
		Debug.Log("Set");
		m_FuelAmount = 1;
	}
	
	// Update is called once per frame
	void Update () 
	{
		/*
		if (Input.GetKey("down") && m_FuelAmount > 0)
		{
			if (m_FuelAmount - m_FuelConsumption <= 0)
				m_FuelAmount = 0;
			else
				m_FuelAmount -= m_FuelConsumption;

			UpdateJauge();
		}
		
		if (Input.GetKeyDown("up"))
			AddFuel(0.2f);

		if (Input.GetKeyDown("left"))
		{
			m_ExplosionParticleSystem.Emit(500);
		}
		*/
	}

	private void UpdateJauge()
	{
		Vector3 newScale = Vector3.one;
		newScale.x = m_FuelAmount;
		m_JaugeFillTransform.localScale = newScale;
	}

	public void AddFuel(float amount)
	{
		if (m_FuelAmount + amount >= 1)
		{
			m_FuelAmount = 1;
		}
		else
		{
			m_FuelAmount += amount;
		}

		UpdateJauge();
	}
	
	public void RemoveFuel(float amount)
	{
		
		if (m_FuelAmount - amount <= 0)
		{
			m_FuelAmount = 0;
		}
		else
		{
			m_FuelAmount -= amount;
		}
			
		UpdateJauge();
	}

	public float GetFuelAmount()
	{
		return m_FuelAmount;
	}
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Jauge : MonoBehaviour
{
	public GameObject m_JaugeFill;
	public float m_FuelConsumption = 0.01f;
	
	private RectTransform m_JaugeFillTransform;
	private float m_FuelAmount;

	void Awake()
	{
		m_JaugeFillTransform= m_JaugeFill.GetComponent<RectTransform>();
	}

	// Use this for initialization
	void Start ()
	{
		m_FuelAmount = 1;
	}
	
	// Update is called once per frame
	void Update () 
	{
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
			m_FuelAmount = 1;
		else
			m_FuelAmount += amount;

		UpdateJauge();
	}
}

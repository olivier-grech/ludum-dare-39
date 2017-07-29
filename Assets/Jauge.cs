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
		m_FuelAmount = 1.0f;
	}
	
	// Update is called once per frame
	void Update () 
	{
		if (Input.GetKey("down") && m_FuelAmount > 0)
		{
			Vector3 newScale = Vector3.one;

			if (m_FuelAmount - m_FuelConsumption <= 0)
			{
				m_FuelAmount = 0;
				newScale.x = 0;
			}
			else
			{
				m_FuelAmount -= m_FuelConsumption;
				newScale.x = m_JaugeFillTransform.localScale.x - m_FuelConsumption;
			}
			
			m_JaugeFillTransform.localScale = newScale;
		}
	}
}

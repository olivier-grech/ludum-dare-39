﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Planet : MonoBehaviour
{

	public Collider2D col;

	private GameObject thisGameObject;
	private LevelManager m_LevelManager;
	
	// Use this for initialization
	private void Awake()
	{
		m_LevelManager = LevelManager.instance;
		col = GetComponent<Collider2D>();
		thisGameObject = this.transform.parent.gameObject;
	}

	void Start ()
	{
		
	}
	
	// Update is called once per frame
	void Update () 
	{
		
	}

	private void OnTriggerEnter2D(Collider2D other)
	{
		if (m_LevelManager == null) return;
		//m_LevelManager.SetCurrentAttractor(thisGameObject.GetComponent<GravityAttractor>());
		other.gameObject.GetComponent<GravityBody>().attractor = thisGameObject.GetComponent<GravityAttractor>();
		Debug.Log(other.gameObject.GetComponent<GravityBody>().attractor.gameObject.ToString());
	}

	private void OnTriggerExit2D(Collider2D other)
	{
		other.gameObject.GetComponent<GravityBody>().attractor = null;
		Debug.Log("Untriggered");
	}
}

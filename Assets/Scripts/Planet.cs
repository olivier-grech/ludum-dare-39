﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Planet : MonoBehaviour
{

	public Collider2D col;

	private GameObject thisGameObject;
	private LevelManager m_LevelManager;
	
	// Use this for initialization
	void Start ()
	{
		m_LevelManager = LevelManager.instance;
		col = GetComponent<Collider2D>();
		thisGameObject = this.transform.parent.gameObject;
	}
	
	// Update is called once per frame
	void Update () 
	{
		
	}

	private void OnTriggerEnter2D(Collider2D other)
	{
		m_LevelManager.SetCurrentAttractor(thisGameObject.GetComponent<GravityAttractor>());
		Debug.Log(m_LevelManager.GetCurrentAttractor());
	}

	private void OnTriggerExit2D(Collider2D other)
	{
		m_LevelManager.SetCurrentAttractor(null);
		Debug.Log("Untriggered");
	}
}

﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelObjective : MonoBehaviour {
	
	private GameManager m_GameManager;
	private LevelManager m_LevelManager;

	// Use this for initialization
	void Start () 
	{
		m_GameManager = GameManager.instance;
		m_LevelManager = LevelManager.instance;
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	private void OnTriggerEnter2D(Collider2D other)
	{

		if (other.GetComponent<Ship>() != null)
		{
			m_GameManager.m_CompletedLevels[m_GameManager.m_CurrentLevelIndex] = true;
			for (int i = 0; i < 6; i++)
				Debug.Log(m_GameManager.m_CompletedLevels[i]);
			
			if (m_GameManager.m_LevelsList[m_GameManager.m_CurrentLevelIndex + 1] != null)
				m_GameManager.ChangeLevel(m_GameManager.m_CurrentLevelIndex + 1);
			else
				m_LevelManager.ReturnToMenu();
			
		}
			
	}
}

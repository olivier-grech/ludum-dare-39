using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelObjective : MonoBehaviour {
	
	private GameManager m_GameManager;

	// Use this for initialization
	void Start () 
	{
		m_GameManager = GameManager.instance;
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	private void OnTriggerEnter2D(Collider2D other)
	{

		if (other.GetComponent<Ship>() != null)
		{
			Debug.Log("Niveau fini");
			m_GameManager.m_CompletedLevels[m_GameManager.m_CurrentLevelIndex] = true;
			for (int i = 0; i < 6; i++)
				Debug.Log(m_GameManager.m_CompletedLevels[i]);
			
			m_GameManager.ChangeLevel(m_GameManager.m_CurrentLevelIndex + 1);
		}
			
	}
}

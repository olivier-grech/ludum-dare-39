using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelManager : MonoBehaviour {
	
	private GameManager m_GameManager;

	// Use this for initialization
	void Start () 
	{
		
		m_GameManager = GameManager.instance;

		GameObject.Instantiate(m_GameManager.m_LevelsList[m_GameManager.m_CurrentLevelIndex]);

	}
	
	// Update is called once per frame
	void Update () 
	{
		if (Input.GetButton("Cancel"))
		{
			ReturnToMenu();
		}	
	}

	void ReturnToMenu()
	{
		SceneManager.LoadScene("Menu");
	}
}

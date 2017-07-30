using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelManager : MonoBehaviour 
{
	public static LevelManager instance;
	
	private GameManager m_GameManager;
	public static GravityAttractor m_Player1Attraction;
	
	// Use this for initialization
	void Start ()
	{
		instance = this;
		m_GameManager = GameManager.instance;
		
		Debug.Log(m_GameManager);
		Object.Instantiate(m_GameManager.m_LevelsList[m_GameManager.m_CurrentLevelIndex]);

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

	public GravityAttractor GetCurrentAttractor()
	{
		return m_Player1Attraction;
	}

	public void SetCurrentAttractor(GravityAttractor attractor)
	{
		m_Player1Attraction = attractor;
	}
}

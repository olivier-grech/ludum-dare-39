using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class LevelManager : MonoBehaviour 
{
	public static LevelManager instance;
	
	private GameManager m_GameManager;
	public static GravityAttractor m_Player1Attraction;
	public GameObject m_TutorialIndicator;
	

	void Awake()
	{
		instance = this;
		m_GameManager = GameManager.instance;
		
		Debug.Log(m_GameManager);
		Object.Instantiate(m_GameManager.m_LevelsList[m_GameManager.GetCurrentLevelIndex()]);
	}
	
	// Use this for initialization
	void Start ()
	{
		if (m_GameManager.GetCurrentLevelIndex() == 0)
		{
			StartCoroutine(ShowTutorialIndicator());
		}
		

	}
	
	// Update is called once per frame
	void Update () 
	{
		if (Input.GetButton("Cancel"))
		{
			ReturnToMenu();
		}	
		else if (Input.GetButton("Fire1"))
		{
			ReloadLevel();
		}
	}

	public void ReturnToMenu()
	{
		SceneManager.LoadScene("Menu");
	}

	public void ReloadLevel()
	{
		Debug.Log("Reolad");
		SceneManager.LoadScene("Level");
	}

	public GravityAttractor GetCurrentAttractor()
	{
		return m_Player1Attraction;
	}

	public void SetCurrentAttractor(GravityAttractor attractor)
	{
		m_Player1Attraction = attractor;
	}

	IEnumerator ShowTutorialIndicator()
	{
		float timer = 7.0f;
		
		m_TutorialIndicator.SetActive(true);

		while (timer > 0)
		{
			timer -= Time.deltaTime;
			yield return null;
		}
		
		m_TutorialIndicator.SetActive(false);
	}
}

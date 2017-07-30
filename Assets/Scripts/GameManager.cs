using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
	public static GameManager instance;
	
	public static GravityAttractor p1Attraction;
	[HideInInspector] public bool[] m_CompletedLevels;
	public GameObject[] m_LevelsList;
	public int m_CurrentLevelIndex;

	void Awake()
	{
		// Define a singleton
		DontDestroyOnLoad(this);
		instance = this;
		
		m_CompletedLevels = new bool[6];
	
		for (int i = 0; i < m_CompletedLevels.Length; i++)
		{
			m_CompletedLevels[i] = false;
		}
	}
	
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	
	public void ChangeLevel(int levelIndex)
	{
		m_CurrentLevelIndex = levelIndex;
		SceneManager.LoadScene("Level");
	}
}

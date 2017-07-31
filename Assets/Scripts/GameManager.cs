using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
	public static GameManager instance;
	public static bool awoken = false;
	
	
	[HideInInspector] public bool[] m_CompletedLevels;
	public GameObject[] m_LevelsList;
	public static int m_CurrentLevelIndex;
	public AudioSource m_AudioSourceLevelFinishedSound;

	void Awake()
	{
		if (!awoken)
		{
			awoken = true;
			
			// Define a singleton
			DontDestroyOnLoad(this);
			instance = this;
			
			m_CompletedLevels = new bool[6];
		
			for (int i = 0; i < m_CompletedLevels.Length; i++)
			{
				m_CompletedLevels[i] = true;
			}
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
		SetCurrentLevelIndex(levelIndex);
		SceneManager.LoadScene("Level");
	}

	public int GetCurrentLevelIndex()
	{
		return m_CurrentLevelIndex;
	}

	public void SetCurrentLevelIndex(int index)
	{
		m_CurrentLevelIndex = index;
	}

	public void PlayLevelFinishedSound()
	{
		m_AudioSourceLevelFinishedSound.Play();
	}
}

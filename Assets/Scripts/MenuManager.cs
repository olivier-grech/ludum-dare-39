using System.Collections;
using System.Collections.Generic;
using JetBrains.Annotations;
using UnityEngine;
using UnityEngine.UI;

public class MenuManager : MonoBehaviour
{
	public GameObject m_LevelButtonsGrid;

	private GameManager m_GameManager;

	public GameObject m_MenuTab;
	public GameObject m_AboutTab;

	public GameObject m_CongratulationsMessage;

	void Awake()
	{
		
	}

	// Use this for initialization
	void Start ()
	{
		m_GameManager = GameManager.instance;
		
		Button[] levelButtons = m_LevelButtonsGrid.GetComponentsInChildren<Button>();

		int i = 0;
		foreach (var button in levelButtons)
		{
			// Le premier niveau est toujours disponible
			if (i == 0)
			{
				button.interactable = true;
			}
			else
			{
			
				button.interactable = m_GameManager.m_CompletedLevels[i-1];
			}
			
			
			i++;
		}

		if (PlayerPrefs.GetInt("levelCompleted", -1) >= 12)
		{
			m_CongratulationsMessage.SetActive(true);
		}
			

	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void SwitchTabToMenu()
	{
		m_AboutTab.SetActive(false);
		m_MenuTab.SetActive(true);
	}
	
	public void SwitchTabToAbout()
	{
		m_MenuTab.SetActive(false);
		m_AboutTab.SetActive(true);
	}
}

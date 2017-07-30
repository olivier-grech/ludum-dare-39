using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MenuManager : MonoBehaviour
{
	public GameObject m_LevelButtonsGrid;

	private GameManager m_GameManager;

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

	}
	
	// Update is called once per frame
	void Update () {
		
	}
}

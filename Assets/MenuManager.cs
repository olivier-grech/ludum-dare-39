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
			Debug.Log(m_GameManager.CompletedLevels[i]);
			button.interactable = m_GameManager.CompletedLevels[i];
			i++;
		}

	}
	
	// Update is called once per frame
	void Update () {
		
	}
}

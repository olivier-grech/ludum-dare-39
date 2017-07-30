using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
	public static GameManager instance;
	
	// What 
	public static GravityAttractor p1Attraction;
	
	// Boolean array of completed levels
	[HideInInspector]
	public bool[] CompletedLevels;

	void Awake()
	{
		// Define a singleton
		DontDestroyOnLoad(this);
		instance = this;
		
		CompletedLevels = new bool[6];
		CompletedLevels[0] = true;
		for (int i = 1; i < CompletedLevels.Length; i++)
		{
			CompletedLevels[i] = false;
		}
	}
	
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Planet : MonoBehaviour
{

	public Collider2D col;

	private GameObject thisGameObject;
	// Use this for initialization
	void Start () {
		col = GetComponent<Collider2D>();
		thisGameObject = this.transform.parent.gameObject;
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	private void OnTriggerEnter2D(Collider2D other)
	{
		GameManager.p1Attraction = thisGameObject.GetComponent<GravityAttractor>() ;
		Debug.Log(GameManager.p1Attraction);
	}

	private void OnTriggerExit2D(Collider2D other)
	{
		GameManager.p1Attraction = null;
		Debug.Log("Untriggered");
	}
}

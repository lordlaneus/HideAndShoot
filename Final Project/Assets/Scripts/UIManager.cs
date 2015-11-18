using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class UIManager : MonoBehaviour {

	public Slider player1health;
	public Slider player2health;

	// Use this for initialization
	void Start () {
	
		player1health.value = 99.0f;
		player2health.value = 99.0f;

	}
	
	// Update is called once per frame
	void Update () {
	
		// if player loses health, change the value of the sliding handle

		// if a players health is low, change the color to red

		// if a player dies, lose one of the heart images

	}

	void OnTrigerEnter(Collider myTrigger) {
		// if a player collects a life, restore 20 health

	}
}

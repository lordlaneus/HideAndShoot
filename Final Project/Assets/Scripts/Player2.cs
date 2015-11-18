using UnityEngine;
using System.Collections;

public class Player2 : MonoBehaviour {

	public float moveSpeed;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
		if (Input.GetKey(KeyCode.UpArrow))
		{
			transform.position += transform.forward * Time.deltaTime * moveSpeed;
		}
		
		if (Input.GetKey(KeyCode.DownArrow))
		{
			transform.position += -transform.forward * Time.deltaTime * moveSpeed;
		}
		
		if (Input.GetKey (KeyCode.LeftArrow))
		{
			transform.position += -transform.right * Time.deltaTime * moveSpeed;
		}
		if (Input.GetKey (KeyCode.RightArrow))
		{
			transform.position += transform.right * Time.deltaTime * moveSpeed;
		}

	}
}

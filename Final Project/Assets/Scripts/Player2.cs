using UnityEngine;
using System.Collections;

public class Player2 : MonoBehaviour {

	public float moveSpeed;
	
	public float currentHealth;
	public float maxHealth;
	public int lives;

	public Bullet bullet;

	// Use this for initialization
	void Start () {
	
		currentHealth = maxHealth;
		lives = 3;

	}
	
	// Update is called once per frame
	void Update () {
	
		// lives and death
		if (currentHealth <= 0) {
			lives -= 1;
			currentHealth = maxHealth;
		}
		
		if (lives == 0) {
			gameObject.SetActive(false);
		}

		// shoot
		if (Input.GetKeyDown (KeyCode.RightShift)) {
			Shoot();
		}


		// player movement
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

	
	void OnCollisionEnter (Collision col){
		
		if (col.collider.tag == "Enemy") {
			currentHealth -= 5;
		}
		
		if (col.collider.tag == "Bullet") {
			currentHealth -= 5;
		}
	}
	
	void Shoot(){
		// instantiate new bullet and set it equal to newBullet
		Bullet newBullet = (Bullet) Instantiate (bullet, transform.position + transform.forward, Quaternion.identity);
		newBullet.direction = transform.forward;
	}
}

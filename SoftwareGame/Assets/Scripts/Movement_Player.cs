using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement_Player : MonoBehaviour {

	float maxSpeed = 1.6f;
	float rotateSpeed = 1000f;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		//Up Down movement
		transform.Translate (new Vector3 (0, Input.GetAxis ("Vertical") * maxSpeed * Time.deltaTime, 0));
		//Left right movement
		transform.Translate (new Vector3 (Input.GetAxis ("Horizontal") * maxSpeed * Time.deltaTime,0,0));
		//Rotation
		Vector2 direction = Camera.main.ScreenToWorldPoint(Input.mousePosition) - transform.position;
		float angle = Mathf.Atan2 (direction.y, direction.x) * Mathf.Rad2Deg;
		Quaternion rotation = Quaternion.AngleAxis (angle, Vector3.forward);
		transform.rotation = Quaternion.Slerp(transform.rotation, rotation, rotateSpeed * Time.deltaTime);


	}
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseController : MonoBehaviour 
{
	public float JetPackForce = 75.0f;
	private Rigidbody2D PlayerRigidBody;

	// Use this for initialization
	void Start () 
	{
		PlayerRigidBody = GetComponent<Rigidbody2D>();
	}
	
	void FixedUpdate () 
	{
		bool jetPackActive = Input.GetButton("Fire1");
		if (jetPackActive)
		{
			PlayerRigidBody.AddForce(new Vector2(0, JetPackForce));
		}
	}
}

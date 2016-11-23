﻿using UnityEngine;
using System.Collections;

public class Weapon : MonoBehaviour {

	public float Firerate = 10;
	public float Damage = 10;
	public LayerMask NotToHit;

	float TimeToFire = 0;
	Transform firepoint;


	void Awake () {
		firepoint = transform.FindChild("FirePoint");
		if (firepoint == null) {
			Debug.LogError ("FirePoint not found");
		}
	}
	
	// Update is called once per frame
	void Update () 
	{
		if (Firerate == 0) 
		{
			if (Input.GetButtonDown("Fire1"))
			{
				Shoot();

		}
	}
		else 
		{
			if (Input.GetButton("Fire1") && Time.time > TimeToFire) 
			{
				TimeToFire = Time.time + 1/Firerate;
				Shoot();
			}
		}
}
	void Shoot() {
		Vector2 mousePosition = new Vector2 (Camera.main.ScreenToWorldPoint (Input.mousePosition).x, Camera.main.ScreenToWorldPoint (Input.mousePosition).y);
	}
}
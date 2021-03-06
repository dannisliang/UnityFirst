﻿using UnityEngine;
using System.Collections;

public class NewBehaviourScript : MonoBehaviour 
{
	public float speed = 10.0F;
	public float rotationSpeed = 100.0F;
	// Use this for initialization
	void Start () 
	{
	
	}
	
	// Update is called once per frame
	void Update () 
	{
		float translation = Input.GetAxis ("Vertical") * speed;
		float rotation = Input.GetAxis ("Horizontal") * rotationSpeed;
		translation *= Time.deltaTime;
		rotation *= Time.deltaTime;
		transform.Translate (0, 0, translation);//前后移动
		transform.Rotate (0, rotation, 0);//左右旋转
	}
}

﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveBitch : MonoBehaviour {

    public float MoveSpeed;


	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        transform.position = new Vector3(transform.position.x - MoveSpeed * Time.deltaTime, transform.position.y, transform.position.z);
	}
}
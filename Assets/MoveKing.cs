﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveKing : MonoBehaviour {

    // Use this for initialization
	public float moveSpeed; 

	void Start () {
		moveSpeed = 9;
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKeyUp(KeyCode.UpArrow))
			transform.Translate(Vector3.forward * moveSpeed);

        if (Input.GetKeyUp(KeyCode.DownArrow))
            transform.Translate(Vector3.back * moveSpeed);

        if (Input.GetKeyUp(KeyCode.LeftArrow))
            transform.Translate(Vector3.left * moveSpeed);

        if (Input.GetKeyUp(KeyCode.RightArrow))
            transform.Translate(Vector3.right * moveSpeed);

		if (Input.GetKeyUp(KeyCode.W))
			transform.Translate((Vector3.forward + Vector3.left) * moveSpeed);

        if (Input.GetKeyUp(KeyCode.S))
            transform.Translate((Vector3.back + Vector3.right) * moveSpeed);

        if (Input.GetKeyUp(KeyCode.A))
			transform.Translate((Vector3.left + Vector3.back) * moveSpeed);

        if (Input.GetKeyUp(KeyCode.D))
			transform.Translate((Vector3.right + Vector3.forward) * moveSpeed);
    }
}

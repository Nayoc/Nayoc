﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
	public float speed = 5f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
	void Update()
	{
		float moveX = Input.GetAxisRaw("Horizontal");//水平 -1,0,1
		float moveY = Input.GetAxisRaw("Vertical");//垂直 -1,0,1

		Vector2 position = transform.position;
		position.x += moveX * speed * Time.deltaTime;
		position.y += moveY * speed * Time.deltaTime;

		transform.position = position;
	}
}

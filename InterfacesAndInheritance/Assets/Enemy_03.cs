using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy_03 : BaseEnemy {

    private float timeSinceJump = 0;
    private bool up;

	// Use this for initialization
	void Start () {
        health = 3;
        speed = 1;
	}
	
    public override void Move()
    {
        base.Move();
        timeSinceJump += Time.deltaTime;
        if (timeSinceJump > 2){
            if (up)
            {
                transform.position -= Vector3.up * 2;
                timeSinceJump = 0;
            }
            else
            {
                transform.position += Vector3.up * 2;
                timeSinceJump = 0;
            }
            up = !up;
        }
    }
}

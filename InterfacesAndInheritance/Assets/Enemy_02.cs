using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy_02 : BaseEnemy {

	// Use this for initialization
	void Start () {
        health = 2;
	}
	
    public override void Move()
    {
        base.Move();
        transform.position += Vector3.up * Time.deltaTime * Mathf.Sin(Time.time);
    }
}

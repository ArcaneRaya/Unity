using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BaseWall : MonoBehaviour, IDamagable {

    int structuralHealth;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

    }

    public void TakeDamage(int damage)
    {
        structuralHealth -= damage;
        if (structuralHealth <= 0)
        {
            DestroyWall();
        }
    }

    protected void DestroyWall () {
        Destroy(gameObject);
    }
}

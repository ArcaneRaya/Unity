using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class BaseEnemy : MonoBehaviour, IDamagable {

    protected int health;
    protected int speed = 2;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	protected void Update () {
        Move();
	}

    public virtual void Move(){
        transform.position += Vector3.right * Time.deltaTime * speed;
    }

    public void TakeDamage (int damage){
        health -= damage;
        if (health <= 0){
            Die();
        }
    }

    protected void Die(){
        Destroy(gameObject);
    }

    private void OnMouseDown()
    {
        TakeDamage(1);
    }
}

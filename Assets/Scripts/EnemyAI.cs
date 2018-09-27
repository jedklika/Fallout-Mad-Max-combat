using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyAI : MonoBehaviour {

    public float speed;

    public float stoppingDistance;

    private Transform target;

    public int health;

	// Use this for initialization
	void Start () {
        target = GameObject.FindGameObjectWithTag("Player").GetComponent<Transform>();
    }
    public void TakeDamage(int damage)
    {
        health -= damage;
    }
	
	// Update is called once per frame
	void Update () {
		if(Vector2.Distance(transform.position, target.position)> stoppingDistance)
        {
            transform.position = Vector2.MoveTowards(transform.position, target.position, speed * Time.deltaTime);
        }
        if (health <= 0)
        {
            GameObject.Destroy(this.gameObject);
        }
	}
}

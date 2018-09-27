using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyAI : MonoBehaviour {

    public float speed;

    public float stoppingDistance;

    public float retreatDistance;

    private Transform target;

    public int health;

    private float TimeBtwShot;

    public float StartTimeBtwShot;

    public GameObject Projectile;

    // Use this for initialization
    void Start () {
        target = GameObject.FindGameObjectWithTag("Player").GetComponent<Transform>();
        TimeBtwShot = StartTimeBtwShot;
    }
    public void TakeDamage(int damage)
    {
        health -= damage;
    }

    // Update is called once per frame
    void Update() {
        if (Vector2.Distance(transform.position, target.position) > stoppingDistance)
        {
            transform.position = Vector2.MoveTowards(transform.position, target.position, speed * Time.deltaTime);
        }
        else if (Vector2.Distance(transform.position, target.position) < stoppingDistance && (Vector2.Distance(transform.position, target.position) > retreatDistance))
        {
            transform.position = this.transform.position;
        }
        else if (Vector2.Distance(transform.position, target.position) < retreatDistance)
        {
            transform.position = Vector2.MoveTowards(transform.position, target.position, -speed * Time.deltaTime);
        }
        if (health <= 0)
        {
            GameObject.Destroy(this.gameObject);
        }
        if (TimeBtwShot <= 0)
        {
            Instantiate(Projectile, transform.position, Quaternion.identity);
            TimeBtwShot = StartTimeBtwShot;
        }
        else
            {
                TimeBtwShot -= Time.deltaTime;
            }
        
    }
    }

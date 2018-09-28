using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProjectileFoe : MonoBehaviour {
    public float speed;
    public float lifeTime;
    private Transform Player;
    private Vector2 target;
    public int damage;

    // Use this for initialization
    void Start()
    {
        Invoke("DestroyProjectile", lifeTime);
        Player = GameObject.FindGameObjectWithTag("Player").transform;
        target = new Vector2(Player.position.x, Player.position.y);

    }

    // Update is called once per frame
    void Update()
    {
        transform.position = Vector2.MoveTowards(transform.position, target, speed * Time.deltaTime);
        
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            Player.GetComponent<Player>().TakeDamage(damage);
            DestroyProjectile();       
        }
    }
    void DestroyProjectile()
    {
        GameObject.Destroy(this.gameObject);
    }
}


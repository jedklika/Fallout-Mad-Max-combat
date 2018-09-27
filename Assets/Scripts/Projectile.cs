using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile : MonoBehaviour {
    public float speed;
    public float lifeTime;
    public Vector3 target;
	// Use this for initialization
	void Start () {
        Invoke("DestroyProjectile", lifeTime);
	}
	
	// Update is called once per frame
	void Update () {
        target = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        transform.position= Vector2.MoveTowards(transform.position,target, speed * Time.deltaTime*5);
	}
    void DestroyProjectile()
    {
        GameObject.Destroy(this.gameObject);
    }
    }

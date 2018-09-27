using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile : MonoBehaviour {
    public float speed;
    public float lifeTime;
	// Use this for initialization
	void Start () {
        Invoke("DestroyProjectile", lifeTime);
	}
	
	// Update is called once per frame
	void Update () {
        transform.Translate(transform.up * speed * Time.deltaTime);
	}
    void DestroyProjectile()
    {
        GameObject.Destroy(this.gameObject);
    }
    }

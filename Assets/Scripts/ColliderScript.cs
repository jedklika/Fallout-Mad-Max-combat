using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ColliderScript : MonoBehaviour {
    public BoxCollider2D col;


    // Use this for initialization
    void Start () {
        col = GetComponent<BoxCollider2D>();
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            SceneManager.LoadScene("Practice");
        }
    }
}

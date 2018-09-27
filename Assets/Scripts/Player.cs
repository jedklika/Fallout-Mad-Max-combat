using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Player : MonoBehaviour
{
    [SerializeField] string loadLevel;

    private Vector3 target;
    public BoxCollider2D col;
    public int health;

    void Start()
    {
        col = GetComponent<BoxCollider2D>();

    }
    public void TakeDamage(int damage)
    {
        health -= damage;
    }
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            target = Camera.main.ScreenToWorldPoint(Input.mousePosition);   
        }
        transform.position = Vector2.MoveTowards(transform.position, target, Time.deltaTime * 5);

        if (health <= 0)
        {
            GameObject.Destroy(this.gameObject);
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Collider")
        {
            Debug.Log("Its hit bitch");
            SceneManager.LoadScene(loadLevel);
        }
    }
}

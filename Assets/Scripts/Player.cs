using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Player : MonoBehaviour
{


   
    private Vector3 target;
    public BoxCollider2D col;

    void Start()
    {
        col = GetComponent<BoxCollider2D>();

    }
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            target = Camera.main.ScreenToWorldPoint(Input.mousePosition);   
        }
        transform.position = Vector2.MoveTowards(transform.position, target, Time.deltaTime * 5);
    }
    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Collider"))
        {
            SceneManager.LoadScene("Practice");
        }
    }
}

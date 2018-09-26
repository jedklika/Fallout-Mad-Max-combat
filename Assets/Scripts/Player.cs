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
<<<<<<< HEAD
        if (move == true)
            transform.position = Vector2.MoveTowards(transform.position, target, speed * Time.deltaTime);
=======
        transform.position = Vector2.MoveTowards(transform.position, target, Time.deltaTime * 5);
>>>>>>> a6fe424c98de9c333ceb53e95e799fabf1e498f4
    }
    void OnTriggerEnter2D(Collider2D collision)
    {
<<<<<<< HEAD
        if (col.CompareTag("Collider"))
=======
        if (collision.CompareTag("Collider"))
>>>>>>> a6fe424c98de9c333ceb53e95e799fabf1e498f4
        {
            SceneManager.LoadScene("Combat");
        }
    }
}

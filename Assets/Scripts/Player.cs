using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Player : MonoBehaviour
{


    public float speed;
    private bool move = false;
    public GameObject point;
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
            target.z = transform.position.z;
            if (move == false)
                move = true;
            Instantiate(point, target, Quaternion.identity);
        }
        if (move == true)
            transform.position = Vector2.MoveTowards(transform.position, target, speed * Time.deltaTime);
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (col.CompareTag("Collider"))
        {
            SceneManager.LoadScene("Combat");
        }
    }
}

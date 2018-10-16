using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Player : MonoBehaviour
{
    //[SerializeField] string loadLevel;

    public BoxCollider2D col;
    public int health;
    float moveHorizontal;
    float moveVertical;
    public int speed = 5;

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
        moveHorizontal = Input.GetAxis("Horizontal");
        moveVertical = Input.GetAxis("Vertical");
        transform.Translate(new Vector2(moveHorizontal * Time.deltaTime * speed, moveVertical * Time.deltaTime * speed));
        if (Input.GetAxis("Horizontal") < 0 )
        {
             
        }
        if(Input.GetAxis("Horizontal") > 0)
        {
           
        }
       
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Collider")
        {
            Debug.Log("Its hit bitch");
            SceneManager.LoadScene("Practice");
        }
        if (collision.tag == "Foe")
        {
            SceneManager.LoadScene("Combat");
        }
    }

}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChanger : MonoBehaviour {

    public BoxCollider2D col;

    private void Start()
    {
        col = GetComponent<BoxCollider2D>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Collider")
            SceneManager.LoadScene("Combat");
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Point : MonoBehaviour {	
	void Update () {
        if (Input.GetMouseButton(0))
            GameObject.Destroy(this.gameObject);
    }
}

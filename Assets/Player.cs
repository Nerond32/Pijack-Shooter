using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKeyDown(KeyCode.LeftArrow) && this.transform.position.x > -6)
        {
            Vector3 position = this.transform.position;
            position.x = position.x - 3.5f;
            this.transform.position = position;
        }
        if (Input.GetKeyDown(KeyCode.RightArrow) && this.transform.position.x < 6)
        {
            Vector3 position = this.transform.position;
            position.x = position.x + 3.5f;
            this.transform.position = position;
        }
    }
}

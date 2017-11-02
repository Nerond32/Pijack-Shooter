using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bulletscript : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        Vector3 position = this.transform.position;
        if (position.y > 8.9f)
        {
            Object.Destroy(this.gameObject);
            //position.y = position.y - 20000.0f;
        }
        else
        {
            position.y = position.y + 0.5f;
        }
        this.transform.position = position;
    }
}

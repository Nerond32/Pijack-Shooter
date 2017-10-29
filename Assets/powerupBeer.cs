using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class powerupBeer : MonoBehaviour {

	// Use this for initialization
	void Start () {
        
    }
	
	// Update is called once per frame
	void Update () {
        Vector3 position = this.transform.position;
        if (position.y < -8.9f)
        {
            Destroy(this);
            position.y = position.y - 20000.0f;
        }
        else
        {
            position.y = position.y - 0.1f;
        }
        this.transform.position = position;
    }

    
}

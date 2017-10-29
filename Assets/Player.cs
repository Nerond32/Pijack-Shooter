using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {
    //public GameObject[] beers;
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

        /*beers = GameObject.FindGameObjectsWithTag("Beer");

        foreach (GameObject beer in beers)
        {
            beer.gameObject.SendMessage("ApplyDamage", 10);
        }*/
     

    }

    void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.name == "Beer")
        {
            Vector3 position = this.transform.position;
            position.x = position.x - 3000.5f;
            this.transform.position = position;
        }
        else
        {
            Vector3 position = this.transform.position;
            position.x = position.x - 3000.5f;
            this.transform.position = position;
        }
    }
}

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
        Vector3 position2 = this.transform.position;
        position2.y = -6.81f;
        this.transform.position = position2;
        
        /*beers = GameObject.FindGameObjectsWithTag("Beer");

        foreach (GameObject beer in beers)
        {
            beer.gameObject.SendMessage("ApplyDamage", 10);
        }*/
     

    }

    void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.tag == "Beer")
        {
            Debug.Log("AAAA");
        }
        if (other.gameObject.tag == "Kar")
        {
            gameObject.GetComponent<SpriteRenderer>().sprite = Resources.Load<Sprite>("pijackheroded");
        }
    }
}

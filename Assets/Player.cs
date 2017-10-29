using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Player : MonoBehaviour {
    //public GameObject[] beers;
    // Use this for initialization
    public Text t;
    public Sprite sprite;
    void Start () {
    }
	
	// Update is called once per frame
	void Update () {
        if (!Assets.DataHendler.isDed)
        {
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
        }
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
            Object.Destroy(other.gameObject);
            Assets.DataHendler.carVelocity += 0.05f;
            Assets.DataHendler.points += 100;
            t.text = "Points: " + Assets.DataHendler.points;
        }
        if (other.gameObject.tag == "Kar")
        {
            Assets.DataHendler.isDed = true;
            this.GetComponent<SpriteRenderer>().sprite = sprite;
        }
    }
}

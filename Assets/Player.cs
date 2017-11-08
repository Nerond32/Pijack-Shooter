using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace Assets
{
    public class Player : MonoBehaviour
    {
        //public GameObject[] beers;
        // Use this for initialization
        public Text tempt;
        public static Text t;
        public Sprite sprite;
        public Text beers;
        void Start()
        {
            t = tempt;
        }

        // Update is called once per frame
        void Update()
        {
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
                if (Input.GetKeyDown(KeyCode.Space) && this.transform.position.x < 6)
                {
                    if (Assets.DataHendler.numberOfBullets > 0)
                    {
                        Vector3 position = this.transform.position;
                        position.z = -3.0f;
                        Instantiate(Resources.Load("BulletPrefab"), position, Quaternion.identity);
                        Assets.DataHendler.numberOfBullets--;
                        beers.text = "Beers: " + Assets.DataHendler.numberOfBullets;

                    }
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
                Assets.DataHendler.numberOfBullets ++;
                beers.text = "Beers: " + Assets.DataHendler.numberOfBullets;
                AddPoints(10);
            }
            if (other.gameObject.tag == "Meth")
            {
                Object.Destroy(other.gameObject);
                Assets.DataHendler.slower += 250;
                AddPoints(50);
            }
                if (other.gameObject.tag == "Kar")
            {
                Assets.DataHendler.isDed = true;
                this.GetComponent<SpriteRenderer>().sprite = sprite;
            }
        }
        
        public static void AddPoints(int amount)
        {
            Assets.DataHendler.points += amount;
            t.text = "Points: " + Assets.DataHendler.points;
        }
    }
}

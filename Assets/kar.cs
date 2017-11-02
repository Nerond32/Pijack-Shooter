using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class kar : MonoBehaviour {
    public Sprite sprite;
    private bool destroyed = false;
    private float baseSpeed = 0.25f;
    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        Vector3 position = this.transform.position;
        if (position.y < -8.9f)
        {
            Object.Destroy(this.gameObject);
            //position.y = position.y - 20000.0f;
        }
        else
        {
            var velModifier = (float)(Assets.DataHendler.points - Assets.DataHendler.slower);
            if (velModifier < baseSpeed) velModifier = baseSpeed;
            var velocity = baseSpeed + Mathf.Sqrt(1.0f+(float)velModifier)/200;
            position.y = position.y - velocity;
            Debug.Log(velocity);
        }
        this.transform.position = position;
    }
    void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.tag == "Bullet")
        {
            destroyed = true;
            this.GetComponent<SpriteRenderer>().sprite = sprite;
            Invoke("DestroyCar", 0.2f);
            Object.Destroy(other.gameObject);
            Assets.Player.AddPoints(200);
        }
    }
    void DestroyCar()
    {
        Object.Destroy(this.gameObject);
    }
}

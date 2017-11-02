using Assets;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour {
    public static float[] positions = { -7.0f , -3.0f, 0.3f, 4.0f, 7.3f };
    //public static string[] powerupNames = { "BeerPrefab", "BeerPrefab", "BeerPrefab", "KarPrefab" };
    public static string[] powerupNames = { "BeerPrefab", "KarPrefab", "MethPrefab" };
    public List<Object> powerups = new List<Object>();
    public Text points;
    // Use this for initialization
   // public ArrayList<GameObject> powerups = new ArrayList<GameObject>();
    void Start () {
        InvokeRepeating("Spawn", 0.0f, 0.4f);
    }
	
	// Update is called once per fram
	void Update () {
    }

    void Spawn()
    {
        var spawn = Random.Range(0, 5);
        var spawnName = Random.Range(0, 3);
        Vector3 position = new Vector3(positions[spawn], 15.0f, -1.0f);
        if (powerupNames[spawnName] == "KarPrefab" && Assets.DataHendler.isDed || !Assets.DataHendler.isDed)
        {
            Instantiate(Resources.Load(powerupNames[spawnName]), position, Quaternion.identity);
        }
    }

    /*void CheckCollisions()
    {
        GameObject player = GameObject.FindGameObjectsWithTag("Player");
        foreach(GameObject pup in powerups)
        {

        }
    }*/

    void OnCollisionEnter2D(Collision2D coll)
    {
        if (coll.gameObject.tag == "Enemy")
            coll.gameObject.SendMessage("ApplyDamage", 10);

    }
}

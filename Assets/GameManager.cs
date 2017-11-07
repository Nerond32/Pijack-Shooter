using Assets;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.Text.RegularExpressions;
public class GameManager : MonoBehaviour {
    public static float[] positions = { -7.0f , -3.0f, 0.3f, 4.0f, 7.3f };
    //public static string[] powerupNames = { "BeerPrefab", "BeerPrefab", "BeerPrefab", "KarPrefab" };
	public static string[] powerupNames = { "BeerPrefab", "KarPrefab1","KarPrefab2","KarPrefab3","KarPrefab4", "MethPrefab" };
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
		var spawnName = Random.Range(0, 6);
		var spawn =  isKarPrefab(powerupNames[spawnName]) ? Random.Range(1, 4) : Random.Range(0, 5);       
        Vector3 position = new Vector3(positions[spawn], 15.0f, -1.0f);

		if ( isKarPrefab(powerupNames[spawnName])  && Assets.DataHendler.isDed || !Assets.DataHendler.isDed)
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


	bool isKarPrefab(string prefab) {
		Regex r = new Regex ("KarPrefab[2-9]");
		return r.IsMatch (prefab);
	}

    void OnCollisionEnter2D(Collision2D coll)
    {
        if (coll.gameObject.tag == "Enemy")
            coll.gameObject.SendMessage("ApplyDamage", 10);

    }
}

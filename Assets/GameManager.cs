using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour {
    public static float[] positions = { -7.0f , -3.0f, 0.3f, 4.0f, 7.3f };
    // Use this for initialization
    public GameObject[] beers;
    void Start () {
        InvokeRepeating("SpawnBeer", 0.0f, 0.3f);
    }
	
	// Update is called once per frame
	void Update () {
    }

    void SpawnBeer()
    {
        var spawn = Random.Range(0, 5);
        Vector3 position = new Vector3(positions[spawn], 15.0f, 0.0f);
        Instantiate(Resources.Load("BeerPrefab"), position, Quaternion.identity);
    }
}

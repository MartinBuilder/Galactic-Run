using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RoadGenerator : MonoBehaviour {

    private float spawnz = -100f;
    public GameObject[] prefabs;
    private float RoadLength = 100f;
    private int amountOfRoads = 1;

    private List<GameObject> roadsList;
    private Transform playertransform;

	// Use this for initialization
	void Start () {
        roadsList = new List<GameObject>();
        playertransform = GameObject.FindGameObjectWithTag("Player").transform;
		
	}
	
	// Update is called once per frame
	void Update () {
        if (playertransform.position.z > (spawnz - amountOfRoads * RoadLength))
        {
            SpawnRoad(0);
        }
		
	}

    void SpawnRoad(int prefaIndex)
    {
        GameObject go;
        go = Instantiate(prefabs[prefaIndex]) as GameObject;
        go.transform.SetParent(transform);
        go.transform.position = Vector3.forward * spawnz;
        spawnz += RoadLength;
        roadsList.Add(go);
    }
}

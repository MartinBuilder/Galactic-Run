using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RoadGenerator : MonoBehaviour
{
    private float spawnz = -100f;
    public GameObject[] prefabs;
    private float RoadLength = 100f;
    private int amountOfRoads = 5;
    public int amountOfChunks;

    private List<GameObject> roadsList;
    private Transform playertransform;
    
	void Start ()
    {
        roadsList = new List<GameObject>();
        playertransform = GameObject.FindGameObjectWithTag("Player").transform;
	}
	
	void Update ()
    {
        int num = Random.Range(0, amountOfChunks);

        if (playertransform.position.z > (spawnz - amountOfRoads * RoadLength))
        {
            SpawnRoad(num);
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

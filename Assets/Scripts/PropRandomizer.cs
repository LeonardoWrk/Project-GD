using System.Collections;
using System.Collections.Generic;
using System.Numerics;
using Unity.Mathematics;
using UnityEngine;

public class PropRandomizer : MonoBehaviour
{
    public List<GameObject> propSpawnPoints;
    public List<GameObject> propPrefabs;
    // Start is called before the first frame update
    void Start()
    {
        SpawnProps();
    }

    // Update is called once per frame
    void Update()
    {
       
    }

    void SpawnProps() 
    {
        foreach (GameObject sp in propSpawnPoints) 
        { 
            int rand = UnityEngine.Random.Range(0, propPrefabs.Count);
            GameObject prop = Instantiate(propPrefabs[rand], sp.transform.position, UnityEngine.Quaternion.identity);
            prop.transform.parent = sp.transform;
        }
    }
}

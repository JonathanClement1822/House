using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MakePrefabs : MonoBehaviour
{
    public GameObject spherePrefabExampleThing;

    void Start()
    {
        for(int i = 0; i < 100; i++)
        {
            Instantiate(spherePrefabExampleThing, 
                new Vector3(
                    Random.Range(-10.0f, 10.0f), 
                    Random.Range(-8.0f, 8.0f), 
                    Random.Range(0, 15.0f)), 
                Quaternion.identity);
        }
    }
}

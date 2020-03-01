using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WallMaker : MonoBehaviour
{
    public GameObject brick;

    void Start()
    {
        for (int j = 0; j < 10; j++)
        {
            for (int i = 0; i < 5; i++)
            {
                Instantiate(brick, new Vector3(i, j, 0), Quaternion.identity);
            }
        }   
    }
}

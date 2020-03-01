using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveLeftAndRight : MonoBehaviour
{
    bool falseMoveRightTrueMoveLeft;

    public float speed;

    void Start()
    {
        
    }

    void Update()
    {
        if (transform.position.x >= 10)
            falseMoveRightTrueMoveLeft = true;
        else if (transform.position.x <= -10)
            falseMoveRightTrueMoveLeft = false;

        if (falseMoveRightTrueMoveLeft == false)
        {
            transform.position = transform.position + Vector3.Normalize(new Vector3(1, 0, 0)) * Time.deltaTime * speed;
        }
        else
        {
            transform.position = transform.position - Vector3.right * Time.deltaTime * speed;
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectRotateAround : MonoBehaviour
{
    float moveTimer, moveThreshold, moveSpeed;
    bool setMoveSpeed = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (!setMoveSpeed)
        {
            moveSpeed = Random.Range(-60, 60);
            moveThreshold = Random.Range(2f, 3f);
            setMoveSpeed = true;
        }
        moveTimer += Time.deltaTime;
        if (moveTimer < moveThreshold)
        {
            transform.RotateAround(new Vector3(0, 0, 0), Vector3.up, moveSpeed * Time.deltaTime);

        }
        else
        {
            setMoveSpeed = false;
            moveTimer = 0;
        }

    }
}

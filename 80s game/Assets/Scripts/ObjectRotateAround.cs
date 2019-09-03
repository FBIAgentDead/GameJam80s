using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectRotateAround : MonoBehaviour
{
    public Transform target;
    float moveTimer, moveThreshold, moveSpeed;
    bool setMoveSpeed = false;

    void Update()
    {
        transform.LookAt(target);
        if (!setMoveSpeed)
        {
            moveSpeed = Random.Range(-60, 60);
            moveThreshold = Random.Range(2f, 3f);
            setMoveSpeed = true;
        }
        moveTimer += Time.deltaTime;
        if (moveTimer < moveThreshold)
        {
            transform.RotateAround(target.position, Vector3.up, moveSpeed * Time.deltaTime);

        }
        else
        {
            setMoveSpeed = false;
            moveTimer = 0;
        }


    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BarrelMovement : MonoBehaviour
{
    public GameObject _target;
    public float heightAmplifier = 5f;
    private Vector3 targetPos;
    private Rigidbody thisRigid;
    public float movementForce = 1f;

    private void Start()
    {
        targetPos = _target.transform.position;
        thisRigid = GetComponent<Rigidbody>();
        transform.LookAt(_target.transform.position);
    }

    private void OnCollisionEnter(Collision collision)
    {
        Vector3 dir = targetPos - transform.position + (Vector3.up * heightAmplifier);
        thisRigid.AddForce(dir.normalized * movementForce, ForceMode.Impulse);
    }

}

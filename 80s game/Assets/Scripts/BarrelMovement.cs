using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BarrelMovement : MonoBehaviour
{
    public GameObject _target;
    private Vector3 targetPos;
    private Rigidbody thisRigid;
    public float movementForce = 1f;

    private void Start()
    {
        _target = GameObject.Find("FollowHead");
        targetPos = _target.transform.position;
        thisRigid = GetComponent<Rigidbody>();
        transform.LookAt(_target.transform.position);
    }

    private void OnCollisionEnter(Collision collision)
    {
        Vector3 dir = (targetPos+new Vector3(0,100,0)) - transform.position;
        //thisRigid.AddForce(Vector3.up * Vector3.Distance(transform.position, targetPos), ForceMode.Impulse);
        thisRigid.AddForce(dir * movementForce/10, ForceMode.Impulse);
    }

}

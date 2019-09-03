using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BarrelThrower : MonoBehaviour {

    public List<GameObject> projectiles;
    public float minCooldown, maxCooldown;
    public float throwForce = 10f;

    private void Start()
    {
        StartCoroutine(StartThrowing());
    }

    private void InstantiateProjectile()
    {
        GameObject currentProjectile = Instantiate(projectiles[Random.Range(0, projectiles.Count)], transform.position, transform.rotation);
        currentProjectile.GetComponent<Rigidbody>().AddForce(-transform.up * throwForce, ForceMode.Impulse);
    }

    private IEnumerator StartThrowing()
    {
        yield return new WaitForSeconds(Random.Range(minCooldown, maxCooldown));
        InstantiateProjectile();
        StartCoroutine(StartThrowing());
    }

}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Experimental.GlobalIllumination;

public class BarrelFlicker : MonoBehaviour {

    public Light effectedLight;
    public float flickerMin, flickerMax;
    private float flickerTarget = 1f;
    private float t = 0;
    public float lerpSpeed = 1;

    private void Start()
    {
        effectedLight = GetComponent<Light>();
    }

    private void NewFlicker()
    {
        flickerTarget = Random.Range(flickerMin, flickerMax);
    }

    private void Update()
    {
        if(effectedLight.intensity != flickerTarget)
        {
            t += lerpSpeed/10;
            effectedLight.intensity = Mathf.Lerp(effectedLight.intensity, flickerTarget, t);
        }
        else
        {
            t = 0;
            NewFlicker();
        }
    }

}

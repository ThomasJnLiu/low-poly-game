using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlickerFire : MonoBehaviour
{
    public float minFlickerIntensity = 0.5f;
    public float maxFlickerIntensity = 2.5f;
    public float flickerSpeed = 0.035f;
    public float randomizer = 0f;

    Light light;

    void Start()
    {
        light = GetComponent<Light>();
    }

    // Update is called once per frame
    void Update()
    {
        StartCoroutine(flicker());
    }

    private IEnumerator flicker()
    {

        if (randomizer == 0)
        {
            light.intensity = (Random.Range(minFlickerIntensity, maxFlickerIntensity));

        }
        else
        {
            light.intensity = (Random.Range(minFlickerIntensity, maxFlickerIntensity));
            randomizer = Random.Range(0f, 1.1f);
            yield return new WaitForSeconds(flickerSpeed);
        }



    }
}





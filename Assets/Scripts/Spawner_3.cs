using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner_3 : MonoBehaviour
{
    public GameObject prop;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(CreateObject());
    }

    private IEnumerator CreateObject()
    {

        yield return new WaitForSeconds(1);
        Instantiate(prop, new Vector3(-14.088f, Random.Range(4.67f, 7.11f), Random.Range(-4.21f, 1.07f)), Quaternion.Euler(new Vector3(0,0,90)));
        StartCoroutine(CreateObject());
    }
}

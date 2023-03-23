using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner_2 : MonoBehaviour
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
        Instantiate(prop, new Vector3(Random.Range(-8.836f, -24.02f), 4.525f, Random.Range(-19.207f, -5.66f)), Quaternion.Euler(new Vector3(-90,0,0)));
        StartCoroutine(CreateObject());
    }
}

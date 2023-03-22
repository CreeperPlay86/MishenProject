using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
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
        Instantiate(prop, new Vector3(Random.Range(-7.597f, -26.77f), 4.345f, Random.Range(-0.606f, -6.543f)), Quaternion.Euler(new Vector3(-90,0,90)));
    }
}

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
        Instantiate(prop, new Vector3(Random.Range(-7.836204f, -26.63f), 4.345f, Random.Range(-19.207f, -13.099f)), Quaternion.Euler(new Vector3(-90,0,90)));
    }
}

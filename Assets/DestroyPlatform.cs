using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyPlatform : MonoBehaviour
{
    private float x;
    public GameObject Pulpit;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine("Respawn", Random.Range(4f,5f));
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    IEnumerator Respawn(float spawnDelay){
        yield return new WaitForSeconds(spawnDelay);
        Destroy(Pulpit);
    }
}

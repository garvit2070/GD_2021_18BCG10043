using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformSpawner : MonoBehaviour
{   
    private float posx;
    private float posz;
    private float posy;
    private float r;
    public GameObject Pulpit;

    // Start is called before the first frame update
    void Start()
    {
            StartCoroutine("Respawn", 2.5f);
    }

    // Update is called once per frame
    void Update()
    {
        posx = GameObject.FindGameObjectWithTag("Pulpit").transform.position.x;
        posz = GameObject.FindGameObjectWithTag("Pulpit").transform.position.z;
        posy = GameObject.FindGameObjectWithTag("Pulpit").transform.position.y;
       
    }

    IEnumerator Respawn(float spawnDelay)
     {
        yield return new WaitForSeconds(spawnDelay);
        r = Random.Range(1,4);
        if(r==1){
             Instantiate(Pulpit, new Vector3(posx+9,posy,posz),Quaternion.identity);
        }
        if(r==2){
            Instantiate(Pulpit, new Vector3(posx-9,posy,posz), Quaternion.identity);
        }
        if(r==3){
            Instantiate(Pulpit, new Vector3(posx,posy,posz+9), Quaternion.identity);
        }
        if(r==4){
            Instantiate(Pulpit, new Vector3(posx,posy,posz-9), Quaternion.identity);
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{   
    public GameObject player;
    float speed =  2f;
    // Start is called before the first frame update
    void Start()
    {
        speed = speed*Time.deltaTime;
        player = GameObject.Find("Player");
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey(KeyCode.D)){
            player.transform.position += new Vector3(speed,0,0);
        }
        if(Input.GetKey(KeyCode.A)){
            player.transform.position += new Vector3(-speed,0,0);
        }
        if(Input.GetKey(KeyCode.W)){
            player.transform.position += new Vector3(0,0,speed);
        }
        if(Input.GetKey(KeyCode.S)){
            player.transform.position += new Vector3(0,0,-speed);
        }

    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Buildings_script : MonoBehaviour
{
    public float deadZone;
    public float movespeed;

    void Start()
    {
        deadZone = -13;
        movespeed = 10;
    }

        // Update is called once per frame
        void Update(){
        transform.position = transform.position + (Vector3.left * movespeed) * Time.deltaTime; //movement based off time not fps, * Time.deltaTime

        if (transform.position.x < deadZone){
            Destroy(gameObject); //gets rid of buildings once they go off screen
        }
    }
}
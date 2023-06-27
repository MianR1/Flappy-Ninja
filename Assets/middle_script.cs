using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class middle_script : MonoBehaviour
{
    public logic_script logic;
    // Start is called before the first frame update
    void Start(){
        logic = GameObject.FindGameObjectWithTag("logic").GetComponent<logic_script>();
    }

    private void OnTriggerEnter2D(Collider2D collision){
        logic.addScore();
    }
}
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class Ninja_Script : MonoBehaviour
{
    public Rigidbody2D rigBod;
    public float jumpStrength;
    public bool ro;
    public logic_script logic;
    public bool ninjaAlive;
    public float offScreen;

    // Start is called before the first frame update
    void Start(){
        ro = false;
        ninjaAlive = true;
        jumpStrength = 12.5f;
        offScreen = 7.0f;
        logic = GameObject.FindGameObjectWithTag("logic").GetComponent<logic_script>();
    }

    // Update is called once per frame
    void Update(){
        if (transform.position.y > offScreen || transform.position.y < -offScreen){
            logic.gameOver();
            ninjaAlive = false;
        }

        if (Input.GetKeyDown(KeyCode.Space) && ninjaAlive)
        {
            rigBod.velocity = Vector2.up * jumpStrength;
            if (ro){
                transform.Rotate(new Vector3(0, 0, -10));
                ro = false;
            } else{
                transform.Rotate(new Vector3(0, 0, 10));
                ro = true;
            }
        }
    }

    private void OnCollisionEnter2D(Collision2D collision){
        logic.gameOver();
        ninjaAlive = false;
    }
}
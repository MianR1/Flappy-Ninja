using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Buildings_Spawn : MonoBehaviour
{
    public GameObject building;
    public float spawnRate;
    private float timer;

    // Start is called before the first frame update
    void Start(){
        spawnRate = 1;
        timer = 0;
        spawnBuildings();   
    }

    // Update is called once per frame
    void Update()
    {
        if (timer < spawnRate){
            timer += Time.deltaTime;
        }
        else{
            spawnBuildings();
            timer = 0;
        }
    }

    void spawnBuildings() {
        float lowest = 2.5f;
        float highest = 11;

        Instantiate(building, new Vector3(transform.position.x+.5f, Random.Range(lowest,highest),0), transform.rotation); //buildings spawner
    }
}
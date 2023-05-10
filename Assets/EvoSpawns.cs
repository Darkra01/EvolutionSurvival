using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EvoSpawns : MonoBehaviour
{
    public GameObject Spawned;
    public float spawnInterval = 5f;
    private float prevSpawnTime = 0f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Time.time - prevSpawnTime> spawnInterval){
            Spawn();
            prevSpawnTime = Time.time;
        }
        
    }

    public void Spawn(){
        Instantiate(Spawned,transform.position,Quaternion.identity);
    }
}

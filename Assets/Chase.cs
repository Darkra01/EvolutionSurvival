using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Chase : MonoBehaviour
{
    public GameObject player;
    private float moveSpeed = 3f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 directionOfPlayer = player.transform.position - transform.position;
        transform.Translate(directionOfPlayer.normalized*moveSpeed*Time.deltaTime,Space.World);
        transform.LookAt(player.transform.position);
    }
}

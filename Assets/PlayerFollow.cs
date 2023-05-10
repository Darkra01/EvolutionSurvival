using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerFollow : MonoBehaviour
{
    public GameObject player;
    public float offsetHeight = 0.05f;
    public float offsetDistance = 10f;
    // Start is called before the first frame update
    void Start()
    {
        //offset = transform.position- player.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        //transform.position = player.transform.position + offset;
    }

    void LateUpdate(){
        Vector3 targetPosition = player.transform.position - player.transform.forward * offsetDistance;
        targetPosition.y = targetPosition.y +offsetHeight;
        transform.position = Vector3.Lerp(transform.position,targetPosition,Time.deltaTime * 4f);
        transform.LookAt(player.transform.position);
    }
}

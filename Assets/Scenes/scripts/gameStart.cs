using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gameStart : MonoBehaviour
{
    public GameObject level_1;
    public GameObject player;
    private Transform playerTransform;
    private float StartdestroyTime = 15f;


    // Start is called before the first frame update
    void Start()
    {
        playerTransform = GameObject.FindGameObjectWithTag("Player").transform;
        Vector3 startPosition = playerTransform.position + Vector3.down;
        GameObject newLevel = Instantiate(level_1, startPosition, Quaternion.identity);
        newLevel.name = level_1.name;
        Debug.Log("Starting Platform Spawned");
        Destroy(newLevel, StartdestroyTime);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

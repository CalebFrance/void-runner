using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gameStart : MonoBehaviour
{
    public GameObject level_1;
    public GameObject Portal;
    public GameObject startCircle;
    public GameObject player;
    private Transform playerTransform;
    private float StartdestroyTime = 15f;
    private float circledestroyTime = 20f;


    // Start is called before the first frame update
    void Start()
    {
        playerTransform = GameObject.FindGameObjectWithTag("Player").transform;

        Vector3 circlePosition = playerTransform.position;
        Vector3 startPosition = playerTransform.position + Vector3.down;
        Vector3 voidPosition = playerTransform.position + Vector3.forward + Vector3.forward;
        GameObject newLevel = Instantiate(level_1, startPosition, Quaternion.identity);
        GameObject newPortal = Instantiate(Portal, voidPosition, Quaternion.identity);
        GameObject newCircle = Instantiate(startCircle, circlePosition, Quaternion.identity);

        newLevel.name = level_1.name;
        Debug.Log("Starting Platform Spawned");
        Destroy(newLevel, StartdestroyTime);
        Destroy(newPortal, StartdestroyTime);
        Destroy(newCircle, circledestroyTime);
    }

    // Update is called once per frame
    void Update()
    {

    }
}


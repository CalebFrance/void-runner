using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;





public class spawnprefab : MonoBehaviour
{
    //public Collider player;
    public GameObject columns;
   
    public GameObject tutorial_level; // The prefab to instantiate/spawned
    public bool lvl_cleared = false;
    public bool start = false;
    public List<GameObject> levels = new List<GameObject>();
    public GameObject[] storedLevels;
    private Vector3 spawnPointPosition;
    public GameObject spawnPoint;
    public float spawnInterval = 3f;

    private float spawnDistance = 30f;
    private float destroyTime = 8f;
    public Vector3 spawnPosition;
    private Transform playerTransform;
    public Vector3 position;



    void Start()
    {
        
        
    }

    void levelSpawn()
    {

        playerTransform = GameObject.FindGameObjectWithTag("Player").transform;
        // spawnPointPosition = spawnPoint.GetComponent<GameObject>(spawnPoint);

        Vector3 position = playerTransform.position + Vector3.forward * spawnDistance;
        Debug.Log("Spawn Position Created");


        levels.Add(columns);
        GameObject newLevel = Instantiate(levels[0], position, Quaternion.identity);
        newLevel.name = levels[0].name;

        Debug.Log("Levels instantiated");

        Destroy(newLevel, destroyTime);


    }



    public void OnTriggerEnter(Collider other)
    {
       

        if (gameObject.CompareTag("spawn"))
        {
            Debug.Log("found trigger");
            //Trigger location x 3.26 y -3.4 z 205.1104

            //This spawns the first coloumns prefab if the there is only 1 level (Tutorial Level) in the list
            for (int platform = 0; platform < 1; platform++)

            {
                levelSpawn();
                

                if (platform == 5)
                {
                    break;
                }
            }
        }

        if (gameObject.CompareTag("instantColumnTrig"))
        {
            for(int i = 0; i < 1; i++) 
            {
                levelSpawn();
            }

            Debug.Log("Coloumn for loop succesfull");
        }


    }
   






};


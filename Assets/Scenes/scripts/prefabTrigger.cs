using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class prefabTrigger : MonoBehaviour
{
    private Transform playerTransform;
    public List<GameObject> levels = new List<GameObject>();
    public GameObject level_1;
    public GameObject level_2;
    public GameObject player;
  
    private float spawnDistance = 108f;
    private float spawnDistance2 = 35f;
    private float spawnDistance3 = 31.4f;
    private float PlatformdestroyTime = 8f;
    private float TunneldestroyTime = 30f;
    public Vector3 spawnPosition;
    public bool GameRunning = true;
    public int platforms;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    void Update()
    {
        if (playerTransform == null)
        {
            GameRunning = false;
        }
    }

    void SpawnRoad()
    {

        playerTransform = GameObject.FindGameObjectWithTag("Player").transform;

        //spawnPosition uses the players transform position, and the spawnDistance float which is the point at which the next prefab is located
        Vector3 spawnPosition = playerTransform.position + Vector3.forward * spawnDistance;

        Vector3 spawnPosition2 = playerTransform.position + Vector3.forward * spawnDistance2;

        Vector3 spawnPosition3 = playerTransform.position + Vector3.forward * spawnDistance3;

        spawnPosition.y = 0;
        spawnPosition.x = 0.5f;

        spawnPosition.y = 0;
        spawnPosition.x = 0.5f;

        spawnPosition.y = 0;
        spawnPosition.x = 0.5f;

        if (platforms < 10)
        {

            //The prefabs folder then populates the levels list using the LoadAll function
            levels = Resources.LoadAll<GameObject>("Prefabs/level 1").ToList();

            //This adds the first level game object to tthe list
            levels.Add(level_1);
            Debug.Log("Level 1 Start");
            //A new level is generated and the level 1 prefab is instantiated in the spawnPosition Vector3
            GameObject newLevel = Instantiate(levels[0], spawnPosition, Quaternion.identity);
            Debug.Log("Level 1 instantiated");

            //this makes sure that the heiarchy displays the instatiated level shows up with it's name and not a clone 
            newLevel.name = levels[0].name;


            //destroys the new platform using the destroy timer
            Destroy(newLevel, PlatformdestroyTime);
        }


        if (platforms >= 10)
        {

            levels = Resources.LoadAll<GameObject>("Prefabs/tutorial_level").ToList();

            //This adds the first level game object to tthe list
            levels.Add(level_2);
            Debug.Log("Level 2 Added");
            //A new level is generated and the level 1 prefab is instantiated in the spawnPosition Vector3

            if (platforms < 6)
            {
                GameObject newLevel2 = Instantiate(levels[0], spawnPosition3, Quaternion.identity);
                Debug.Log("Level 2 instantiated");


                //this makes sure that the heiarchy displays the instatiated level shows up with it's name and not a clone then destroys the object
                newLevel2.name = levels[0].name;
                Destroy(newLevel2, TunneldestroyTime);
            }
            else
            {
                GameObject newLevel2 = Instantiate(levels[0], spawnPosition2, Quaternion.identity);
                Debug.Log("Level 2 instantiated");

                //this makes sure that the heiarchy displays the instatiated level shows up with it's name and not a clone then destroys the object
                newLevel2.name = levels[0].name;
                Destroy(newLevel2, TunneldestroyTime);


            }
            //destroys the new platform using the destroy timer

        }


        if (platforms == 0)
        {
            Debug.Log("Game Not Yet Started");
        }
        // else { Debug.Log("Level 2 failed to instantiate"); } 


    }



    public void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("spawn"))
        {
            if (GameRunning != true)

            {
                platforms++;
                SpawnRoad();
            }


        }

       
    }
}




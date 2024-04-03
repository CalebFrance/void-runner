using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawnprefab : MonoBehaviour
{
    public Collider player;
    public GameObject columns;
    public GameObject lvl1_trigger;
    public GameObject tutorial_level; // The prefab to instantiate/spawned
    public Collider instant_trigger;
    
    public Collider destroy;
    public int score;
    public bool lvl_cleared = false;
    public bool start = false;
    public List<GameObject> levels = new List<GameObject>();



    public void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            //Trigger location x 3.26 y -3.4 z 205.1104

            Debug.Log("found trigger");
            levels.Add(columns); 
            Debug.Log("Levels Added to list");
            // Instantiate the prefab 
         
            Instantiate(levels[0], new Vector3((float)4.0, (float)5.2, (float)303.0), Quaternion.identity);

            Debug.Log("columns prefab instantiated");

        }

    }

    private void Start()
    {

    }


};


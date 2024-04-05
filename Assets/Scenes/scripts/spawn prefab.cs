using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
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
    public GameObject[] storedLevels;


    public void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            Debug.Log("found trigger");
            //Trigger location x 3.26 y -3.4 z 205.1104
            // if (!levels.Contains(other.gameObject)) { }


                levels.Add(columns);
                Debug.Log("Levels Added to list");

                

                // Instantiate the prefab 

                Instantiate(levels[0], new Vector3((float)4.0, (float)5.2, (float)303.0), Quaternion.identity);

                Debug.Log("columns prefab instantiated");

                storedLevels = Resources.LoadAll<GameObject>("Prefabs/columns");
                levels = Resources.LoadAll<GameObject>("Prefabs/columns").ToList();
                Debug.Log("columns stored");
            
        }

    }

    private void Start()
    {

    }


};


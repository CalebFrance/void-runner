using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawnprefab : MonoBehaviour
{

    public GameObject columns;
    public GameObject tutorial_level; // The prefab to instantiate/spawned
    public Collider instant_trigger;
    //public Collider lvl1_trigger;
    public Collider destroy;
    public int score;
    public bool lvl_cleared = false;
    public bool start = false;
    
    public List<GameObject> levels = new List<GameObject>();

    public Vector3 newSection;

    // spawn();

    void OnTriggerEnter(Collider other)
    {

        if (other.CompareTag("spawn"))
        {
            //Trigger location x 3.26 y -3.4 z 205.1104

            Debug.Log("found trigger");
            levels.Add(columns);
            // Instantiate the prefab 
            Instantiate(levels[1], new Vector3((float)0.0, (float)6.0, (float)303.0), Quaternion.identity);

            Debug.Log("columns prefab instantiated");

        }

        else
        {
            Debug.Log("Failed to run coloumns instatiation");
        };
    }

    private void Start()
    {
     
        
 
    }



    // Start is called before the first frame update


    // Update is called once per frame



 
    




};


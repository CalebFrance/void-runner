using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class deathtoprefabs : MonoBehaviour
{
    public GameObject tutorial_level;
    public GameObject Destroy_lvl0;
    public GameObject lvl1_trigger;


    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {


            if (tutorial_level.gameObject.CompareTag("Tutorial Level"))
            {
                Debug.Log("Located target for destruction");

                GameObject[] others = GameObject.FindGameObjectsWithTag("Tutorial Level");
                GameObject[] trigs = GameObject.FindGameObjectsWithTag("spawn");

                foreach (GameObject tutorial_level in others) 
                {
                    Destroy(tutorial_level);
                } ;

                foreach (GameObject lvl1_trigger in trigs)
                {
                    Destroy(lvl1_trigger);
                };

                

                Debug.Log("All Tutorial Objects Destroyed");
            }

            else 
            {
                Debug.Log("Object failed to destroy");
            }
        }
        else 
        {
            Debug.Log("Could not locate collider");
        }
    }

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

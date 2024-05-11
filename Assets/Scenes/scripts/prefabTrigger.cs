using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class prefabTrigger : MonoBehaviour
{
    private Transform playerTransform;
    public List<GameObject> levels = new List<GameObject>();
    public GameObject level_1;
    public GameObject player;
    public int score;
    private float spawnDistance = 21.50f;
    private float destroyTime = 8f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    void Update()
    {

    }

    void SpawnRoad()
    {



        //This finds the player object transformation
        playerTransform = GameObject.FindGameObjectWithTag("Player").transform;

        //spawnPosition uses the players transform position, and the spawnDistance float which is the point at which the next prefab is located
        Vector3 spawnPosition = playerTransform.position + Vector3.forward * spawnDistance;

        //The prefabs folder then populates the levels list using the LoadAll function
        levels = Resources.LoadAll<GameObject>("prefabs").ToList();
        levels.Add(level_1);
        GameObject newLevel = Instantiate(levels[0], spawnPosition, Quaternion.identity);
        newLevel.name = levels[0].name;

        Debug.Log("Levels instantiated");

        Destroy(newLevel, destroyTime);


    }

    public Vector3 spawnPosition;



    public void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("spawn"))
        {
            for (int platform = 0; platform < 1; platform++)

            {
                SpawnRoad();

                if (platform == 4)
                {
                    break;
                }
            }
        }


        if (other.CompareTag("Score"))
        {
            score++;

            Destroy(other.gameObject); //Kill

            Debug.Log("Score: " + score);
        }

    }
}




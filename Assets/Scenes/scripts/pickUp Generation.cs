using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pickUpGeneration : MonoBehaviour
{
    public GameObject PickUp_Score;
    public GameObject PickUp_Speed;
    public Collider levelCollider;
    // Start is called before the first frame update
    void Start()
    {
        TrueSpawn();
    }

    void TrueSpawn() 
    {
        int i = 0;
        int scoreNo = 5;//token amount
        if (i < scoreNo)
        {
           
            Vector3 randomSpawnPosition = new Vector3(Random.Range(0.1f, 0.9f), 3, 0);
            Instantiate(PickUp_Score, randomSpawnPosition, Quaternion.identity);
           
        }
        
    }

    void SpawnPower()
    {
       
        Vector3 GetRandomPointInCollider(Collider collider)//function to get the location for coin spawn
        {
            Vector3 point = new Vector3
                (
                    Random.Range(collider.bounds.min.x, collider.bounds.max.x),//This sets the random spwan to always be on the platform
                    Random.Range(collider.bounds.min.y, collider.bounds.max.y),
                    Random.Range(collider.bounds.min.z, collider.bounds.max.z)
                );

            point.y = 5;

            if (point != collider.ClosestPoint(point))
            {
                point = GetRandomPointInCollider(collider) +Vector3.up;//sets the coins to spwan on the platform
            }

            //point.y = 1;//makes the coins spawn on the ground
            return point;
        }


        int scoreNo = 5;//token amount
        for (int i = 0; i < scoreNo; i++)
        {
            GameObject score = Instantiate(PickUp_Score, transform);//spawns token
            score.transform.position = GetRandomPointInCollider(GetComponent<Collider>());
        }
    }



    // Update is called once per frame
    void Update()
    {
        
    }
}

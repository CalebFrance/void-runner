using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pickUpGeneration : MonoBehaviour
{
    public GameObject PickUp_Score;
    // Start is called before the first frame update
    void Start()
    {
        SpawnPower();
    }

    void SpawnPower()
    {
        int scoreNo = 4;//token amount
        for (int i = 0; i < scoreNo; i++)
        {
            GameObject score = Instantiate(PickUp_Score, transform);//spawns token
            score.transform.position = GetRandomPointInCollider(GetComponent<Collider>());
        }
    }

    Vector3 GetRandomPointInCollider(Collider collider)//function to get the location for coin spawn
    {
        Vector3 point = new Vector3
            (
                Random.Range(collider.bounds.min.x, collider.bounds.max.x),//This sets the random spwan to always be on the platform
                Random.Range(collider.bounds.min.y, collider.bounds.max.y),
                Random.Range(collider.bounds.min.z, collider.bounds.max.z)
            );

        if (point != collider.ClosestPoint(point))
        {
            point = GetRandomPointInCollider(collider) + Vector3.up;//sets the coins to spwan on the platform
        }

        //point.y = 1;//makes the coins spawn on the ground
        return point;
    }



    // Update is called once per frame
    void Update()
    {
        
    }
}

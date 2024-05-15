using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class createEnemy : MonoBehaviour
{
    public GameObject level_1;

    public GameObject level_3;

    public GameObject enemy;

    public Transform levelTransform;

    public float spawnDistance = 5f;

    public Collider levelCollider;
    
    // Start is called before the first frame update


    void Start()
    {
        //  levelTransform = GameObject.FindGameObjectWithTag("Level").transform;
        //  Vector3 enemyPosition = levelTransform.position * spawnDistance;
        //GameObject newEnemy = Instantiate(enemy, enemyPosition, Quaternion.identity);

        EnemySpawn();
    }

    public void EnemySpawn()
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



            //point.y = 1;//makes the coins spawn on the ground
            return point;
        }

        int scoreNo = 4;//token amount
        for (int i = 0; i < scoreNo; i++)
        {
            GameObject score = Instantiate(enemy);//spawns token
            score.transform.position = GetRandomPointInCollider(GetComponent<Collider>());
        }
    }

    // Update is called once per frame
    void Update()
    {

    }
}
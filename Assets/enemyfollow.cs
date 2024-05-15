using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEditor.PlayerSettings;

public class enemyfollow : MonoBehaviour
{

    public Transform targetObj;
    public float playerKillInterval = 7f;
    public float pos;
    public float fallheight;
    public GameObject enemy;



    // Start is called before the first frame update
    void Start()
    {
        
    }

    public void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("kill enemy")) 
        {
            Destroy(enemy);
            Debug.Log("Enemy Hit Collider, bro's dead");
        }
    }


    // Update is called once per frame
    void Update()
    {
        transform.position = Vector3.MoveTowards(this.transform.position, targetObj.position, 25 *  Time.deltaTime);

        pos = enemy.transform.position.y;

        if (pos <= -10f)
        {
            Destroy(gameObject);
            Debug.Log("Enemy Despawned");
        }

    }
}

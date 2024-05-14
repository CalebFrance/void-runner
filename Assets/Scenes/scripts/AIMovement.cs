using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class AIMovement : MonoBehaviour
{
    public Transform playerTransforms;
    public float maxTime = 1.0f;
    public float minDistance = 1.0f;
   

    public NavMeshAgent agent;
    float timer = 0.4f;

    // Start is called before the first frame update
    void Start()
    {
        if (agent != null)
        {
            agent = GetComponent<NavMeshAgent>();
        }

        else 
        {
            Debug.Log("Couldn't locate agent");
        }
        
    }

    // Update is called once per frame
    void Update()
    {
        timer -= Time.deltaTime;
        if (timer < 0.0f)
        {
            

            float sqDistance = (playerTransforms.position - agent.destination).sqrMagnitude;
            if (sqDistance > minDistance * minDistance)
            {
                agent.destination = playerTransforms.position;
            }
            timer = maxTime;
        }
    }
}



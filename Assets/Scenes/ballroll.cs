using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Ballroll : MonoBehaviour
{
    public float speed;
    
    private Rigidbody rb;

    public int score;

    public float time = 1f;

    public GameObject player;
    private Transform playerTransform;

    // Start is called before the first frame update

    
    // Update is called once per frame
    void Update()
    {
        rb = GetComponent<Rigidbody>();
        float moveHorizontal = Input.GetAxisRaw("Horizontal");
        float moveVertical = Input.GetAxisRaw("Vertical");
        Vector3 roll = new Vector3(x:moveHorizontal, y:0, z:moveVertical);
        Vector3 Jump = new Vector3(x:0, y:0, z: moveVertical);
        playerTransform = GameObject.FindGameObjectWithTag("Player").transform;
        rb.AddForce(roll * (speed * Time.deltaTime));
        rb.AddForce( Jump * (speed * Time.deltaTime));
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Speed"))
        {
            if (Time.time > 2f)
            {
                speed = speed * time;
                
                playerTransform.position += new Vector3(0, 0, 2) * Time.fixedDeltaTime;

                Destroy(other.gameObject);
               

            }

            Debug.Log("Player Speed Increased");
        }

        if (other.CompareTag("Score"))
        {
            score++;

            Destroy(other.gameObject); //Kill

            Debug.Log("Score: " + score);
        }

       // if(other.gameObject.tag == "Coin")
      //  {
      //      ScoreManager.scoreCount += 1;
      //      ScoreManager.hiScoreCount += 1;
      //      Destroy(other.gameObject);
      //  }

       

    }


}

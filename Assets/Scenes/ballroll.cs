using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class Ballroll : MonoBehaviour
{
    public float speed;
    
    private Rigidbody rb;
    public int score;
    public float time = 1f;
    public List<GameObject> levels = new List<GameObject>();
    public GameObject columns;
    public GameObject tutorial_level;

    //public GameObject lvl1_trigger;
    // Start is called before the first frame update

    private void Start()
    {

        void spawn()
        {
            if (levels.Count == 0)
            {
                if (tutorial_level.gameObject.CompareTag("Tutorial Level"))
                {

                    //Instantiate(tutorial_level, new Vector3(4, 6, 303), Quaternion.identity);
                    levels.Add(tutorial_level);
                    Instantiate(tutorial_level, new Vector3((float)0.5876492, (float)7.237311, (float)-31.1104), Quaternion.identity);

                    Debug.Log("Tutorial Prefab Spawned");
                }

            }
            else
            {
                Debug.Log("Levels List full");

            }

        }
        spawn();

    }
    // Update is called once per frame
    void Update()
    {
        rb = GetComponent<Rigidbody>();
        float moveHorizontal = Input.GetAxisRaw("Horizontal");
        float moveVertical = Input.GetAxisRaw("Vertical");
        Vector3 roll = new Vector3(x:moveHorizontal, y:0, z:moveVertical);

        rb.AddForce(roll * (speed * Time.deltaTime));

    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Speed"))
        {
            if (Time.time > 2f)
            {
                speed = speed * time;

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


       /* if (other.CompareTag("spawn"))
        {
            //Trigger location x 3.26 y -3.4 z 205.1104

            Debug.Log("found trigger");
            levels.Add(columns); Debug.Log("Levels Added to list");
            // Instantiate the prefab 
            Instantiate(levels[1], new Vector3((float)0.0, (float)6.0, (float)303.0), Quaternion.identity);

            Debug.Log("columns prefab instantiated");

        } */



        if (gameObject.CompareTag("Destroy"))
        {
            Destroy(gameObject);
            Debug.Log("Level Destroyed");

        }

    }

    
}

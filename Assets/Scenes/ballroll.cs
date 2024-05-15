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

    


}

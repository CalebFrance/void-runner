using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawnprefab : MonoBehaviour
{

    public GameObject columns;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("spawn"))
        { 
        Instantiate(columns, new Vector3(4,6,303), Quaternion.identity);
        }
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

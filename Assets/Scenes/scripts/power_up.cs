using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class power_up : MonoBehaviour
{
    public float speed;
    public float time;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Speed"))
        {
            if (Time.time > 2f)
            {
                speed = speed * time;
                Debug.Log("Speed Increased");
                // playerTransform.position += new Vector3(0, 0, 2) * Time.fixedDeltaTime;

                Destroy(other.gameObject);

            }

        }

        if (other.CompareTag("Slow"))
        {
            if (Time.time > 2f)
            {

                speed = speed / time;
                Debug.Log("Slowed down");
                // playerTransform.position += new Vector3(0, 0, 2) * Time.fixedDeltaTime;
                Destroy(other.gameObject);
            }

        }

        if (other.CompareTag("Stop"))
        {
            GetComponent<Rigidbody>().velocity = Vector3.zero;

            transform.position = Vector3.zero;

            Destroy(other.gameObject); //Kill

            Debug.Log("Test scripts");
        }

    }

}

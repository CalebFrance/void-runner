using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameOverScreen : MonoBehaviour
{
    // Reference to the player object
    public GameObject player;

    // Height at which the game should consider the player as "fallen"
    public float fallHeight;

    //position
    public float pos;

    // Update is called once per frame
    void Update()
    {

        pos = player.transform.position.y;

        // Check if the player's Y position is below the fall height
        if (pos <= -10f )
        {
            // Call the GameOver function
            GameOver();
        }
    }

    // Function to handle the game over condition
    void GameOver()
    {
        if (gameObject.CompareTag("Player"))
        {
            Destroy(gameObject);
        }
        else
        {
            Debug.Log("Failed to destroy player");
        }

        //SceneManager.LoadSceneAsync(2);
    }
}



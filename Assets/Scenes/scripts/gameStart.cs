using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gameStart : MonoBehaviour
{
    public GameObject tutorial_level;
    public List<GameObject> levels = new List<GameObject>();

    // Start is called before the first frame update
    void Start()
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
                Debug.Log("Levels List populated");

            }

        }
        spawn();

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

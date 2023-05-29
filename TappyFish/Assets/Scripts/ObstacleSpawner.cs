using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleSpawner : MonoBehaviour
{
    public GameObject obstacle;
    void Start()
    {
        InstentiateObstacle();
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    public void InstentiateObstacle()
    {
        GameObject newObstacle = Instantiate(obstacle);
        newObstacle.transform.position = new Vector2(transform.position.x, transform.position.y);
    }
}

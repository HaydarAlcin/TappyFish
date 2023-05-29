using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleSpawner : MonoBehaviour
{
    public GameObject obstacle;
    float timer;
    public float maxTime;

    public float maxY;
    public float minY;
    float randomY;
    
    void Start()
    {
        //InvokeRepeating("InstentiateObstacle()", 0,maxTime);
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;

        if (timer >= maxTime)
        {
            InstentiateObstacle();
            timer = 0;
        }
    }


    public void InstentiateObstacle()
    {
        randomY = Random.Range(minY,maxY);
        GameObject newObstacle = Instantiate(obstacle);
        newObstacle.transform.position = new Vector2(transform.position.x, randomY);
    }
}

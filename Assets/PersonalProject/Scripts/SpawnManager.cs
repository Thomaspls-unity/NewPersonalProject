using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject obstaclePrefab;
    public GameObject powerUpPrefab;

    private Vector3 obstaclePos = new Vector3(25, 0, 0);
    private float maxYPos = 13;
    private float minYPos = 5;

    private float startDelay = 2;
    private float repeatRate = 2;

    private PlayerController playerControllerScript;
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnObstacle", startDelay, repeatRate);
        InvokeRepeating("SpawnPower", startDelay, repeatRate);
        playerControllerScript = GameObject.Find("Player").GetComponent<PlayerController>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void SpawnObstacle()
    {
        if (playerControllerScript.gameOver == false)
        {
            Instantiate(obstaclePrefab, obstaclePos, Quaternion.identity);
        }
    }

    public void SpawnPower()
    {
        if (playerControllerScript.gameOver == false)
        {
            Instantiate(powerUpPrefab, RandomPos(), Quaternion.identity);
        }
    }

    public Vector3 RandomPos()
    {
        return new Vector3(Random.Range (minYPos, maxYPos), 0);
    }
}

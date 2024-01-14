using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject[] obstaclePrefabs;
    public GameObject scorePrefab;

    private Vector3 obstaclePos = new Vector3(25, 2, 0);
    private float maxPosY = 13;
    private float minPosY = 5;

    private PlayerController playerControllerScript;
    // Start is called before the first frame update
    void Start()
    {
        playerControllerScript = GameObject.Find("Player").GetComponent<PlayerController>();
        StartCoroutine(SpawnObstacle());
        StartCoroutine(SpawnScore());
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    IEnumerator SpawnScore()
    {
        while (playerControllerScript.gameOver == false)
        {
            int randomRepeat = Random.Range(5, 15);
            Vector3 spawnPos = new Vector3(25, Random.Range(minPosY, maxPosY), 0);
            Instantiate(scorePrefab, spawnPos, scorePrefab.transform.rotation);
            yield return new WaitForSeconds(randomRepeat);
        }
    }

    IEnumerator SpawnObstacle()
    {
        while (playerControllerScript.gameOver == false)
        {
            int randomRepeat = Random.Range(1, 4);
            int randomObstacle = Random.Range(0, obstaclePrefabs.Length);
            Instantiate(obstaclePrefabs[randomObstacle], obstaclePos, obstaclePrefabs[randomObstacle].transform.rotation);
            yield return new WaitForSeconds(randomRepeat);
        }
    }
}

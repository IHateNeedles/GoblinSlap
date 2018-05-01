using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class goblinSpawn : MonoBehaviour
{
    public GameObject GoblinPrefab;
    public float RandX = 7.25f;
    public float Randy = -4.53f;
    Vector2 whereToSpawn = new Vector2(0,0);
    public float spawnRate = 2f;
    float nextspawn = 2f;
    // Use this for initialization
    void Start()
    {
        InvokeRepeating("Goblin", spawnRate, spawnRate);

    }

    // Update is called once per frame
    void Update()
    {
        //nextspawn = Time.time + spawnRate;
        whereToSpawn = new Vector2(RandX, Randy);

    }

    void Goblin()
    {

        Instantiate(GoblinPrefab, transform.position, Quaternion.identity);

    }
}
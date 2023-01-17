using System.Collections;
using System.Collections.Generic;
using Game_Scripts;
using Scriptable_Objects.Code;
using Unity.Mathematics;
using UnityEngine;
using Random = UnityEngine.Random;

public class Spawner : MonoBehaviour
{
    public AsteroidData spawnData;
    
    public GameObject asteroid;
    public int asteroidMaxAmount;
    public float asteroidSpawnRate;
    public float asteroidSpawnDistance;
    
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("Spawn", 0f, asteroidSpawnRate);
    }

    void Spawn()
    {
        Vector2 spawnPoint = Random.insideUnitCircle.normalized * asteroidSpawnDistance;

        float firingAngle = Random.Range(-25f, 25f);
        Quaternion rot = Quaternion.AngleAxis(firingAngle, new Vector3(0, 0, 1));

        GameObject theAsteroid = Instantiate(asteroid, spawnPoint, rot);
        Vector2 dir = rot * -spawnPoint;
        float forceMultiplier = Random.Range(0.8f, 1.6f);

        theAsteroid.GetComponent<Asteroid>().Kick(forceMultiplier, dir);
    }
}

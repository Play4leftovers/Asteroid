using System;
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
    
    void Start()
    {
        InvokeRepeating("Spawn", 0f, spawnData.asteroidSpawnRate);
    }

    void Spawn()
    {
        #region Check if asteroid maximum exists and if it has been reached
        if (spawnData.asteroidMaxAmountEnabled == true)
        {
            if (transform.childCount > spawnData.asteroidMaxAmount)
            {
                return;
            }
        }
        #endregion
        
        Vector2 spawnPoint = Random.insideUnitCircle.normalized * spawnData.asteroidSpawnDistance;
        float firingAngle = Random.Range(-25f, 25f);
        Quaternion rot = Quaternion.AngleAxis(firingAngle, new Vector3(0, 0, 1));
        
        GameObject theAsteroid = Instantiate(asteroid,spawnPoint, rot, transform);
        
        Vector2 dir = rot * -spawnPoint;
        float forceMultiplier = Random.Range(0.8f, 1.6f);
        float massMultiplier = Random.Range(spawnData.asteroidMassMultiplierMinimum, spawnData.asteroidMassMultiplierMaximum);
        float width = Random.Range(0.75f, 1.25f);
        float height = 1 / width;

        theAsteroid.transform.localScale = new Vector2(width, height) * massMultiplier;
        theAsteroid.GetComponent<Rigidbody2D>().mass = spawnData.asteroidMass * massMultiplier;
        theAsteroid.GetComponent<Asteroid>().Kick(forceMultiplier, dir);
    }
    
    [ExecuteInEditMode]
    private void OnDrawGizmos()
    {
        Gizmos.DrawWireSphere(transform.position, spawnData.asteroidSpawnDistance);
    }
}

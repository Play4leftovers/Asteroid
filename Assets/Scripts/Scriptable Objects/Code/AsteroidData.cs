using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu]
public class AsteroidData : ScriptableObject
{
    public int asteroidDamage;
    public int asteroidMaxAmount;
    public float asteroidSpeed;
    public float asteroidSpawnRate;
    public Vector2[] asteroidPositions;
}

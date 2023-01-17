using UnityEngine;

namespace Scriptable_Objects.Code
{
    [CreateAssetMenu]
    public class AsteroidData : ScriptableObject
    {
        public bool asteroidMaxAmountEnabled;
        public int asteroidMaxAmount;
        public float asteroidSpeed;
        public float asteroidSpawnRate;
        public float asteroidSpawnDistance;
        public float asteroidMass;
        public float asteroidMassMultiplierMinimum;
        public float asteroidMassMultiplierMaximum;
    }
}

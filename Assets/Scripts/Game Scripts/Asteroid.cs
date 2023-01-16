using Scriptable_Objects.Code;
using UnityEngine;

namespace Game_Scripts
{
    public class Asteroid : MonoBehaviour
    {
        public AsteroidData asteroidData;
        
        [SerializeField] private int asteroidDamage;
        [SerializeField] private int asteroidMaxAmount;
        [SerializeField] private float asteroidSpeed;
        [SerializeField] private float asteroidSpawnRate;
        [SerializeField] private Vector2[] asteroidPositions;
        // Start is called before the first frame update
        void Start()
        {
        
        }

        // Update is called once per frame
        void Update()
        {
        
        }
    }
}

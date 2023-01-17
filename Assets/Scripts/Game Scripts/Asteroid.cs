using Scriptable_Objects.Code;
using UnityEngine;

namespace Game_Scripts
{
    public class Asteroid : MonoBehaviour
    {
        public AsteroidData asteroidData;
        private Rigidbody2D _rb;
        
        [SerializeField] private int asteroidDamage;
        [SerializeField] private float asteroidSpeed;
        // Start is called before the first frame update
        void Awake()
        {
            _rb = GetComponent<Rigidbody2D>();
            asteroidDamage = asteroidData.asteroidDamage;
            asteroidSpeed = asteroidData.asteroidSpeed;
        }

        public void Kick(float forceMultiplier, Vector2 dir)
        {
            _rb.velocity = dir.normalized * asteroidSpeed * forceMultiplier;
            _rb.AddTorque(Random.Range(-4f,4f));
        }
        
        public void Break()
        {
            Destroy(gameObject);
        }
    }
}

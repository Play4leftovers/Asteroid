using System;
using Scriptable_Objects.Code;
using UnityEngine;
using Random = UnityEngine.Random;

namespace Game_Scripts
{
    public class Asteroid : MonoBehaviour
    {
        public AsteroidData asteroidData;
        private Rigidbody2D _rb;
        
        // Start is called before the first frame update
        void Awake()
        {
            _rb = GetComponent<Rigidbody2D>();
        }

        public void Kick(float forceMultiplier, Vector2 dir)
        {
            _rb.velocity = dir.normalized * asteroidData.asteroidSpeed * forceMultiplier;
            _rb.AddTorque(Random.Range(-4f,4f));
        }

        private void OnTriggerExit2D(Collider2D other)
        {
            if (other.CompareTag("Background")){ Destroy(gameObject); }
        }

        public void Break()
        {
            if (_rb.mass > 0.7f)
            {
                BreakUp();
                BreakUp();
            }
            Destroy(gameObject);
        }

        private void BreakUp()
        {
            //Do something better later. Make them blast out from the center with a X degree angle from initial direction it travelled
            //Make them not able to hit each other for a few moments to avoid janky physics
            var transform1 = transform;
            Vector2 asteroidPos = transform1.position;
            asteroidPos += Random.insideUnitCircle * 3.5f;

            Asteroid smallAsteroid = Instantiate(this, asteroidPos, transform1.rotation, transform1.parent);
            Vector2 newDir = Random.insideUnitCircle;
            smallAsteroid.GetComponent<Rigidbody2D>().mass = _rb.mass / 2;
            smallAsteroid.Kick(1, newDir);
        }
    }
}

using Scriptable_Objects.Code;
using UnityEngine;

namespace Game_Scripts
{
    public class Asteroid : MonoBehaviour
    {
        public AsteroidData astData;
        private Rigidbody2D _rb;

        // Start is called before the first frame update
        private void Awake()
        {
            _rb = GetComponent<Rigidbody2D>();
        }

        private void OnTriggerExit2D(Collider2D other)
        {
            if (other.CompareTag("Background")) Destroy(gameObject);
        }

        public void Kick(float forceMultiplier, Vector2 dir)
        {
            _rb.velocity = dir.normalized * (astData.asteroidSpeed * forceMultiplier);
            _rb.AddTorque(Random.Range(-4f, 4f));
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
            Vector2 astPos = transform1.position;
            astPos += Random.insideUnitCircle * 3.5f;

            var smallAsteroid = Instantiate(this, astPos, transform1.rotation, transform1.parent);
            var newDir = Random.insideUnitCircle;
            smallAsteroid.GetComponent<Rigidbody2D>().mass = _rb.mass / 2;
            smallAsteroid.Kick(1, newDir);
        }
    }
}
using System;
using Scriptable_Objects.Code;
using UnityEngine;

namespace Game_Scripts
{
    public class Bullet : MonoBehaviour
    {
        public BulletData bulletData;
        
        private Rigidbody2D _rb;
        
        [SerializeField] private int bulletHealth;
        
        // Start is called before the first frame update
        void Awake()
        {
            _rb = GetComponent<Rigidbody2D>();
            
            bulletHealth = bulletData.bulletHealth;
        }

        public void Shoot(Vector2 dir)
        {
            _rb.velocity = dir.normalized * bulletData.bulletSpeed;
        }
        
        private void OnTriggerEnter2D(Collider2D col)
        {
            if (!col.CompareTag("Asteroid")) return;
            col.gameObject.GetComponent<Asteroid>().Break();
            bulletHealth--;
            if (bulletHealth <= 0)
            {
                Destroy(gameObject);
            }
        }

        private void OnTriggerExit2D(Collider2D other)
        {
            if (other.CompareTag("Background")){ Destroy(gameObject); }
        }
    }
}

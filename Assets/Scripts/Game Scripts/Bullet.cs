using System;
using Scriptable_Objects.Code;
using UnityEngine;

namespace Game_Scripts
{
    public class Bullet : MonoBehaviour
    {
        public BulletData bulletData;
        
        private Rigidbody2D _rb;
        
        [SerializeField] private float bulletSpeed;
        [SerializeField] private int bulletMaxAmount;
        [SerializeField] private int bulletHealth;
        
        // Start is called before the first frame update
        void Awake()
        {
            _rb = GetComponent<Rigidbody2D>();
            
            bulletSpeed = bulletData.bulletSpeed;
            bulletHealth = bulletData.bulletHealth;
            bulletMaxAmount = bulletData.bulletMaxAmount;
        } 

        // Update is called once per frame
        void Update()
        {
            
        }

        public void Shoot(Vector2 dir)
        {
            _rb.velocity = dir.normalized * bulletSpeed;
        }
        
        private void OnTriggerEnter2D(Collider2D col)
        {
            if (col.tag != "Asteroid") return;
            col.gameObject.GetComponent<Asteroid>().Break();
            bulletHealth--;
            if (bulletHealth <= 0)
            {
                Destroy(gameObject);
            }
        }

        private void OnTriggerExit2D(Collider2D other)
        {
            if (other.tag == "Background"){ Destroy(gameObject); }
        }
    }
}

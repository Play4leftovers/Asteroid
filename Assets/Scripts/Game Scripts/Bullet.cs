using UnityEngine;

namespace Game_Scripts
{
    public class Bullet : MonoBehaviour
    {
        public Bullet bulletData;
        
        [SerializeField] private float bulletSpeed;
        [SerializeField] private int bulletMaxAmount;
        [SerializeField] private int bulletHealth;
        // Start is called before the first frame update
        void Start()
        {
            bulletSpeed = bulletData.bulletSpeed;
            bulletHealth = bulletData.bulletHealth;
            bulletMaxAmount = bulletData.bulletMaxAmount;
        } 

        // Update is called once per frame
        void Update()
        {
        
        }
    }
}

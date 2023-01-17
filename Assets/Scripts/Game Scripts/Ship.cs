using System;
using Scriptable_Objects.Code;
using Unity.Mathematics;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Composites;

namespace Game_Scripts
{
    public class Ship : MonoBehaviour
    {
        public ShipData shipData;
        public GameObject bullet;
        
        private Rigidbody2D _rb;
        private float _shipRotationDirection;
        private float _shipThrust;

        [SerializeField] private int shipHealth;
        [SerializeField] private Vector2 shipPosition;
        
        // Start is called before the first frame update
        void Awake()
        {
            shipHealth = shipData.shipHealth;

            _rb = GetComponent<Rigidbody2D>();
        }

        // Update is called once per frame
        void Update()
        {
            shipData.shipPosition = shipPosition;
            if (_shipRotationDirection != 0)
                _rb.AddTorque(-(_shipRotationDirection) * shipData.shipRotationForce * Time.deltaTime);
            if(_shipThrust != 0)
                _rb.AddRelativeForce(Vector2.up * (shipData.shipThrustForce * Time.deltaTime), ForceMode2D.Force);

            BoundryCheck();
        }

        private void BoundryCheck()
        {
            var position = transform.position;
            float x = position.x;
            float y = position.y;

            if (x > 11f) { x = x - 22f; }
            if (x < -11f) { x = x + 22f; }
            if (y > 5.3f) { y = y - 10.6f; }
            if (y < -5.3f) { y = y + 10.6f; }

            transform.position = new Vector2(x, y);
        }

        public void Thrust(InputAction.CallbackContext ctx)
        {
            _shipThrust = ctx.ReadValue<float>();
        }

        public void Shoot(InputAction.CallbackContext ctx)
        {
            if (ctx.performed)
            {
                var tempTransform = transform;
                GameObject theBullet = Instantiate(bullet, tempTransform.position, tempTransform.rotation);
                theBullet.GetComponent<Bullet>().Shoot(transform.up);
            }
        }

        public void Rotate(InputAction.CallbackContext ctx)
        {
            _shipRotationDirection = ctx.ReadValue<float>();
        }
    }
}

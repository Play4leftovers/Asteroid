using System;
using Scriptable_Objects.Code;
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
        [SerializeField] private float shipThrustForce;
        [SerializeField] private float shipRotationForce;
        [SerializeField] private Vector2 shipStartPosition;
        [SerializeField] private Vector2 shipPosition;
        
        // Start is called before the first frame update
        void Start()
        {
            shipHealth = shipData.shipHealth;
            shipThrustForce = shipData.shipThrustForce;
            shipRotationForce = shipData.shipRotationForce;
            shipStartPosition = shipData.shipStartPosition;

            _rb = GetComponent<Rigidbody2D>();
        }

        // Update is called once per frame
        void Update()
        {
            shipData.shipPosition = shipPosition;
            if (_shipRotationDirection != 0)
                _rb.AddTorque(-(_shipRotationDirection) * shipRotationForce * Time.deltaTime);
            if(_shipThrust != 0)
                _rb.AddRelativeForce(Vector2.up * (shipThrustForce * Time.deltaTime), ForceMode2D.Force);
        }

        public void Thrust(InputAction.CallbackContext ctx)
        {
            _shipThrust = ctx.ReadValue<float>();
            print(_shipThrust);
        }

        public void Shoot()
        {
            
        }

        public void Rotate(InputAction.CallbackContext ctx)
        {
            _shipRotationDirection = ctx.ReadValue<float>();
        }
    }
}
